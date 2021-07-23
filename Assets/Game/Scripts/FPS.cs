using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPS : MonoBehaviour
{
    public TMP_Text texto;
    int fps;
    bool Cap60FPS = false;
    bool Cap30FPS = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FPSCalculator());

    }

    // Update is called once per frame
    void Update()
    {
        texto.text = fps.ToString();
        if (Cap60FPS == true)
        {
            Cap30FPS = false;
            Application.targetFrameRate = 60;
        }
        if (Cap30FPS == true)
        {
            Cap60FPS = false;
            Application.targetFrameRate = 30;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            Cap30FPS = false;
            Cap60FPS = true;
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            Cap60FPS = false;
            Cap30FPS = true;
        }
    }

    IEnumerator FPSCalculator()
    {
        float flotante = 1 / Time.deltaTime;
        fps = ((int)flotante);
        yield return new WaitForSeconds(1f);
        
        StartCoroutine(FPSCalculator());
    }
}
