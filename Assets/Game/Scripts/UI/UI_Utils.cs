using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Utils : MonoBehaviour
{
    [SerializeField] private GameObject SelectedGO;


    public void SetEnableOrDisable()
    {
        if (SelectedGO.activeSelf)
        {
            SelectedGO.SetActive(false);
           
        }
        else
        {
            SelectedGO.SetActive(true);
           
        }


    }
}
