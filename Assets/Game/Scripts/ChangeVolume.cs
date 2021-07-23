using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;



public class ChangeVolume : MonoBehaviour
{
    public Volume volume;
    public float valor01;
    
    public Vector4 vectorazo;
    public Color ShadowTint;
    
    public HDAdditionalLightData luces;

    public FlexibleColorPicker picker;
    public Material mat01;
   


    void Awake()
    {
        ShadowTint = new Vector4(1,1,1,0);
    }
    // Start is called before the first frame update
    void Start()
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

        vectorazo = ShadowTint;

        // luces.shadowDimmer = valor01;
        // mat01.color = picker.color;


    }


}
