using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMatController : MonoBehaviour
{
    public enum State
    {
        One,
        Two,
    }
    [SerializeField] private State state;

    [Header("Parameters")]
    public float ambientOclussion = 1f;
    public float Metallic;
    public float Smoothness;
    public float Coat;
    public Color ColorTexture = Color.white;


    [Header("Color Picker")]
    public FlexibleColorPicker colorPicker;

    [Space(20f), Header("Others")]
    public Slider AoSlider;
    public Slider MetallicSlider;
    public Slider SmoothnessSlider;
    public Slider CoatSlider;

    public Material TargetMaterial;
    public bool IsPointerOverUI = false;




    void Awake()
    {
        TargetMaterial = GameObject.Find("Sphere").GetComponent<Renderer>().material;
        
        state = State.One;

    }

    void Start()
    {

    }

    void Update()
    {
        
        switch (state)
        {
            case State.One:
                // if (IsPointerOverUI == false)
                    GetMaterialProperties();
                break;

            case State.Two:
                // if (IsPointerOverUI == false)
                    UpdateNewMaterialValue();
                break;
        }

    }

    void GetMaterialProperties()
    {
        ambientOclussion = TargetMaterial.GetFloat("_Occlusion");
        Metallic = TargetMaterial.GetFloat("_Metallic");
        Smoothness = TargetMaterial.GetFloat("_Smoothness");
        Coat = TargetMaterial.GetFloat("_Coat");
        colorPicker.color = TargetMaterial.GetColor("_Color");
        


        AoSlider.value = ambientOclussion;
        MetallicSlider.value = Metallic;
        SmoothnessSlider.value = Smoothness;
        CoatSlider.value = Coat;

        state = State.Two;

    }

    void UpdateNewMaterialValue()
    {
        TargetMaterial.SetFloat("_Occlusion", ambientOclussion);
        TargetMaterial.SetFloat("_Metallic", Metallic);
        TargetMaterial.SetFloat("_Smoothness", Smoothness);
        TargetMaterial.SetFloat("_Coat", Coat);
        TargetMaterial.SetColor("_Color", colorPicker.color);

    }

    public void NewMaterialsVariablesSlider()
    {
        ambientOclussion = AoSlider.value;
        Metallic = MetallicSlider.value;
        Smoothness = SmoothnessSlider.value;
        Coat = CoatSlider.value;
    }

    public void SwitchStateToOne()
    {
        state = State.One;
    }
}
