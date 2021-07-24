using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectActions : MonoBehaviour
{
    public GameObject SelectedGameOBJ;

    [SerializeField] private Slider xRotateSliderOBJ;
    [SerializeField] private Slider yRotateSliderOBJ;

    private float xRotation;
    private float yRotation;
    private Vector3 vRotation;

void Awake()
{
    SelectedGameOBJ = GameObject.Find("Sphere");
}
    public void SliderRotate()
    {
        xRotation = xRotateSliderOBJ.value;
        yRotation = yRotateSliderOBJ.value;
        vRotation = new Vector3(xRotation, yRotation, 0);

        SelectedGameOBJ.transform.eulerAngles = vRotation;
    }
}
