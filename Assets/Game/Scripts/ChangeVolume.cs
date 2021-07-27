using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;



public class ChangeVolume : MonoBehaviour
{
    public Volume volume;


    public Vector4 vectorazo;
    

    public HDAdditionalLightData luces;

    public FlexibleColorPicker picker;

    private Color SetAlfa = new Color(0, 0, 0, 1f);

    [Range(0, 1)]
    public float shadowDimmerValue = 0.9f;





    void Awake()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        // VolumeProfile profile = volume.sharedProfile;
        // profile.Add<ShadowsMidtonesHighlights>(true);

        if (volume.profile.TryGet(out ShadowsMidtonesHighlights _smh))
        {
            // _smh.active = _smh.shadows
            _smh.shadows.Override(vectorazo);
        }

        vectorazo = picker.color - SetAlfa;

        luces.shadowDimmer = shadowDimmerValue;
        // mat01.color = picker.color;


    }


}
