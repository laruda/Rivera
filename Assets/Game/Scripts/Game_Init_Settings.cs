using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Init_Settings : MonoBehaviour
{
    void Awake()
    {
        Physics.autoSimulation = false;
        Application.targetFrameRate = 24;
    }
    
}
