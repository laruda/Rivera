using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Hex : MonoBehaviour
{
    public InputField FirstHex;
    public TMP_InputField SecondHexTMP;

    // Start is called before the first frame update
    void Awake()
    {
        SecondHexTMP = this.gameObject.GetComponent<TMP_InputField>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SecondHexTMP.text = FirstHex.text;
    }
}
