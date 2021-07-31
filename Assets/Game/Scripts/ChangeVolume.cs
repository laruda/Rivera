using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.UI;



public class ChangeVolume : MonoBehaviour
{

    private Vector4 ShadowMiddleLightVariables;

    [Header("Gather Data"),Space(10)]
    public Volume volume;
    public HDAdditionalLightData LightData;
    public Light SunLight;
    public FlexibleColorPicker picker;

    private Color SetAlfa = new Color(0, 0, 0, 1f);


    [Header("Sliders")]
    [SerializeField] private Slider LightIntensitySlider;
    [SerializeField] private Slider LightMultiplayerSlider;
    [SerializeField] private Slider ShadowDimmerSlider;
    [SerializeField] private Slider TemperatureSlider;



    void Awake()
    {

    }


    // Update is called once per frame
    void Update()
    {


        if (volume.profile.TryGet(out ShadowsMidtonesHighlights _smh))
        {

            _smh.shadows.Override(ShadowMiddleLightVariables);
        }

        ShadowMiddleLightVariables = picker.color - SetAlfa;


        AssingPosSliders();


    }

    private void AssingPosSliders()
    {
        LightData.SetIntensity(LightIntensitySlider.value);
        LightData.lightDimmer = LightMultiplayerSlider.value;
        LightData.shadowDimmer = ShadowDimmerSlider.value;
        SunLight.colorTemperature = TemperatureSlider.value;
    }
}
