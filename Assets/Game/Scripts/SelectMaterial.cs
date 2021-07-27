using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SelectMaterial : MonoBehaviour
{


    [Header("Private Data")]
    [SerializeField] private Material selectedMaterial;

    [SerializeField] private float EmissionValue;

    [SerializeField] private UIMatController matProperties;

    [SerializeField] private TMP_Text objNameTMP;
    [SerializeField] private ObjectActions selectOBJ;



    void Awake()
    {
        selectedMaterial = this.gameObject.GetComponent<Renderer>().material;

        selectOBJ = GameObject.Find("GameProperties").GetComponent<ObjectActions>();

        matProperties = GameObject.Find("GameProperties").GetComponent<UIMatController>();

        objNameTMP = GameObject.Find("ObjectNameTMP").GetComponent<TMP_Text>();
        
    }


    // Update is called once per frame
    void Update()
    {

        EmissionValue = selectedMaterial.GetFloat("_EmissionIntensity");

        if (EmissionValue > 0)
        {
            float emissionTemp = EmissionValue;
            emissionTemp -= Time.deltaTime / 2;
            selectedMaterial.SetFloat("_EmissionIntensity", emissionTemp);
            if (emissionTemp < 0.1)
            {
                selectedMaterial.SetFloat("_Rimoffset", 1f);
            }
        }


    }

    void OnMouseDown()
    {
        if (matProperties.IsPointerOverUI == false)
        {
            selectOBJ.SelectedGameOBJ = this.gameObject;
            selectedMaterial.SetFloat("_Rimoffset", 0.26f);
            matProperties.SwitchStateToOne();
            selectedMaterial.SetFloat("_EmissionIntensity", 0.8f);

            objNameTMP.text = this.gameObject.name;
            matProperties.TargetMaterial = selectedMaterial;
        }

    }


}
