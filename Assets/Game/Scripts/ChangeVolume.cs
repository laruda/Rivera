using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.UI;



public class ChangeVolume : MonoBehaviour
{
    public Volume volume;


    public Vector4 vectorazo;


    public HDAdditionalLightData LightData;
    public Light SunLight;

    public FlexibleColorPicker picker;

    private Color SetAlfa = new Color(0, 0, 0, 1f);

    [Range(0, 1)]
    //public float shadowDimmerValue = 0.9f;


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
            
            _smh.shadows.Override(vectorazo);
        }

        vectorazo = picker.color - SetAlfa;


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
