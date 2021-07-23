using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseOverUI : MonoBehaviour
{
    [SerializeField] private UIMatController matProperties;

    void Awake()
    {
        matProperties = GameObject.Find("GameProperties").GetComponent<UIMatController>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        matProperties.IsPointerOverUI = IsMouseOverUI();
    }

   
    public bool IsMouseOverUI(){
        return EventSystem.current.IsPointerOverGameObject();
    }
}
