using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ObjectActions : MonoBehaviour
{
    public GameObject SelectedGameOBJ;
    private GameObject ObjCache;

    [SerializeField] private Slider xRotateSliderOBJ;
    [SerializeField] private Slider yRotateSliderOBJ;
    [SerializeField] private Slider zRotateSliderOBJ;

    private float xRotation;
    private float yRotation;
    private float zRotation;
    private Vector3 vRotation;

    [SerializeField] private float speed;

    void Awake()
    {
        SelectedGameOBJ = GameObject.Find("Sphere");

    }
    void Update()
    {
        UnableFloorSliderRotation();

        SliderResetChecker();

    }

    private void SliderResetChecker()
    {
        if (xRotateSliderOBJ.value > 0)
        {
            SelectedGameOBJ.transform.Rotate((Vector3.right * Time.deltaTime) * (xRotateSliderOBJ.value * speed));

        }

        if (xRotateSliderOBJ.value < 0)
        {
            SelectedGameOBJ.transform.Rotate((Vector3.left * Time.deltaTime) * (xRotateSliderOBJ.value * speed) * -1);

        }

        if (yRotateSliderOBJ.value > 0)
        {
            SelectedGameOBJ.transform.Rotate((Vector3.up * Time.deltaTime) * (yRotateSliderOBJ.value * speed));
        }

        if (yRotateSliderOBJ.value < 0)
        {
            SelectedGameOBJ.transform.Rotate((Vector3.down * Time.deltaTime) * (yRotateSliderOBJ.value * speed) * -1);
        }

        if (zRotateSliderOBJ.value > 0)
        {
            SelectedGameOBJ.transform.Rotate((Vector3.forward * Time.deltaTime) * (zRotateSliderOBJ.value * speed));
        }

        if (zRotateSliderOBJ.value < 0)
        {
            SelectedGameOBJ.transform.Rotate((Vector3.back * Time.deltaTime) * (zRotateSliderOBJ.value * speed) * -1);
        }
    }

    void UnableFloorSliderRotation()
    {
        if (SelectedGameOBJ.name == "Floor")
        {

            xRotateSliderOBJ.interactable = false;
            yRotateSliderOBJ.interactable = false;
            zRotateSliderOBJ.interactable = false;
        }
        else
        {
            xRotateSliderOBJ.interactable = true;
            yRotateSliderOBJ.interactable = true;
            zRotateSliderOBJ.interactable = true;
        }
    }

    public void ResetSliderValue()
    {
        xRotateSliderOBJ.value = 0;
        yRotateSliderOBJ.value = 0;
        zRotateSliderOBJ.value = 0;
    }
}
