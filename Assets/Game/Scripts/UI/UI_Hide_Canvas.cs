using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Hide_Canvas : MonoBehaviour
{
    [Header("Canvas to Hide")]
    [SerializeField] GameObject Canvas01;
    [SerializeField] GameObject Canvas02;

    [Header("Key to Hide UI")]
    [SerializeField] KeyCode hideUIKey;
    [SerializeField] private bool isUIactive = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(hideUIKey))
        {
            if (isUIactive)
            {
                Canvas01.SetActive(false);
                Canvas02.SetActive(false);
                isUIactive = false;
            }
            else
            {
                Canvas01.SetActive(true);
                Canvas02.SetActive(true);
                isUIactive = true;
            }

        }




    }
}
