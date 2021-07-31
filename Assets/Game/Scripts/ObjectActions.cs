using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ObjectActions : MonoBehaviour
{

    [Header("Object Selected"), Space(10)]
    public GameObject SelectedGameOBJ; //  Will recieve an obj from SelectMaterial Script 

    [Header("Rotate Sliders"), Space(10)]
    [SerializeField] private Slider xRotateSliderOBJ;
    [SerializeField] private Slider yRotateSliderOBJ;
    [SerializeField] private Slider zRotateSliderOBJ;

    [Header("Position Sliders"), Space(10)]
    [SerializeField] private Slider xPositionSliderOBJ;
    [SerializeField] private Slider yPositionSliderOBJ;
    [SerializeField] private Slider zPositionSliderOBJ;



    private float _xPosition;
    private float _yPosition;
    private float _zPosition;
    private Vector3 _v3Position;

    [Header("Rotation Speed")]
    [SerializeField] private float speedRotation = 35;


    void Awake()
    {
        SelectedGameOBJ = GameObject.Find("Sphere");

    }
    void Update()
    {
        UnableFloorSliderRotation();

        RotatingObj();

        MoveObjPosition();

    }

    private void RotatingObj() // Reset slider rotation
    {
        if (xRotateSliderOBJ.value > 0)
        {
            SelectedGameOBJ.transform.Rotate((Vector3.right * Time.deltaTime) * (xRotateSliderOBJ.value * speedRotation));

        }

        if (xRotateSliderOBJ.value < 0)
        {
            SelectedGameOBJ.transform.Rotate((Vector3.left * Time.deltaTime) * (xRotateSliderOBJ.value * speedRotation) * -1);

        }

        if (yRotateSliderOBJ.value > 0)
        {
            SelectedGameOBJ.transform.Rotate((Vector3.up * Time.deltaTime) * (yRotateSliderOBJ.value * speedRotation));
        }

        if (yRotateSliderOBJ.value < 0)
        {
            SelectedGameOBJ.transform.Rotate((Vector3.down * Time.deltaTime) * (yRotateSliderOBJ.value * speedRotation) * -1);
        }

        if (zRotateSliderOBJ.value > 0)
        {
            SelectedGameOBJ.transform.Rotate((Vector3.forward * Time.deltaTime) * (zRotateSliderOBJ.value * speedRotation));
        }

        if (zRotateSliderOBJ.value < 0)
        {
            SelectedGameOBJ.transform.Rotate((Vector3.back * Time.deltaTime) * (zRotateSliderOBJ.value * speedRotation) * -1);
        }
    }


    void UnableFloorSliderRotation() // Block Rotation and Position Slider if the Floor is selected
    {
        if (SelectedGameOBJ.name == "Floor")
        {

            xRotateSliderOBJ.interactable = false;
            yRotateSliderOBJ.interactable = false;
            zRotateSliderOBJ.interactable = false;


            xPositionSliderOBJ.interactable = false;
            yPositionSliderOBJ.interactable = false;
            zPositionSliderOBJ.interactable = false;
        }
        else
        {
            xRotateSliderOBJ.interactable = true;
            yRotateSliderOBJ.interactable = true;
            zRotateSliderOBJ.interactable = true;


            xPositionSliderOBJ.interactable = true;
            yPositionSliderOBJ.interactable = true;
            zPositionSliderOBJ.interactable = true;
        }
    }

    public void ResetSliderValue() // this reset the circle slider so Player can keep rotating the object
    {
        xRotateSliderOBJ.value = 0;
        yRotateSliderOBJ.value = 0;
        zRotateSliderOBJ.value = 0;
    }

    public void ResetSliderPosition() // Reset the slider movement position
    {
        xPositionSliderOBJ.value = 0;
        yPositionSliderOBJ.value = 0;
        zPositionSliderOBJ.value = 0;


        Vector3 otherObjectPostition = SelectedGameOBJ.transform.position;

    }

    public void MoveObjPosition() // Move Position Object selected
    {
        if (xPositionSliderOBJ.value >= 0)
        {
            _xPosition = SelectedGameOBJ.transform.position.x;

            _xPosition += xPositionSliderOBJ.value * Time.deltaTime;
        }
        if (yPositionSliderOBJ.value >= 0)
        {
            _yPosition = SelectedGameOBJ.transform.position.y;

            _yPosition += yPositionSliderOBJ.value * Time.deltaTime;
        }
        if (zPositionSliderOBJ.value >= 0)
        {
            _zPosition = SelectedGameOBJ.transform.position.z;

            _zPosition += zPositionSliderOBJ.value * Time.deltaTime;
        }


        if (xPositionSliderOBJ.value <= 0)
        {
            _xPosition = SelectedGameOBJ.transform.position.x;

            _xPosition -= xPositionSliderOBJ.value * Time.deltaTime * -1;
        }
        if (yPositionSliderOBJ.value <= 0)
        {
            _yPosition = SelectedGameOBJ.transform.position.y;

            _yPosition -= yPositionSliderOBJ.value * Time.deltaTime * -1;
        }
        if (zPositionSliderOBJ.value <= 0)
        {
            _zPosition = SelectedGameOBJ.transform.position.z;
            _zPosition -= zPositionSliderOBJ.value * Time.deltaTime * -1;
        }


        _v3Position = new Vector3(_xPosition, _yPosition, _zPosition);
        SelectedGameOBJ.transform.position = _v3Position;


    }
    public void ResetObjPosition()
    {
        SelectedGameOBJ.transform.position = new Vector3(0f, 0.25f, 0f);
    }

    public void ResetObjRotation()
    {

        SelectedGameOBJ.transform.eulerAngles = Vector3.zero;
    }
}
