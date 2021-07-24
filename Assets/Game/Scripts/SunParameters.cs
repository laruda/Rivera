using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SunParameters : MonoBehaviour
{
    [SerializeField] private Slider xSlider;
    [SerializeField] private Slider ySlider;

    private float xRotition = 23f;
    private float yRotation = 16f;
    private Vector3 vRotation;

    private void Awake()
    {
        xSlider.value = xRotition;
        ySlider.value = yRotation;
        
    }


    public void SliderUpdate()
    {
        xRotition = xSlider.value;
        yRotation = ySlider.value;
        vRotation = new Vector3(xRotition, yRotation, 0);


        this.transform.eulerAngles = vRotation;

    }
}
