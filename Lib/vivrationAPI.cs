using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class vivrationAPI : MonoBehaviour
{
    //VivrationAPI for Unity new input system. Plase no modific
    
    private Gamepad gp = null;
    private string GamePadState;
    public float time;
    private bool stx;
    private float a;
    private float b;
    
    private void Start()
    {
        gp = InputSystem.GetDevice<Gamepad>();
    }

    void Update()
    {  
        time -= Time.deltaTime;
        sysTimeVivration(a, b);
    }

    
    
    [MenuItem("GamePad Lib for NewInputSystem/Vivration/TestVivration")]

    static void TestVivration()
    {
        InputSystem.GetDevice<Gamepad>().SetMotorSpeeds(5, 5);
        
    }
    [MenuItem("GamePad Lib for NewInputSystem/Vivration/StopVivration")]

    static void StopVivration()
    {
        InputSystem.GetDevice<Gamepad>().SetMotorSpeeds(0, 0);
        
    }
    [MenuItem("GamePad Lib for NewInputSystem/Vivration/TestFastVivration")]

    static void FastFVivration()
    {
        InputSystem.GetDevice<Gamepad>().SetMotorSpeeds(5, 5);
        InputSystem.GetDevice<Gamepad>().SetMotorSpeeds(0, 0);
    }
    private void sysVivrationSample(float a, float b)
    {
        gp.SetMotorSpeeds(a, b);
        GamePadState = "Vivrating";
    }

    public void VivrationSample(float a, float b)
    {
        sysVivrationSample(a, b);
    }

    public void sysStopVivration()
    {
        sysVivrationSample(0, 0);
    }
    private void sysTimeVivration(float a, float b)
    {
        if (time >= 0)
        {
            VivrationSample(a, b);
            stx = false;
        }

        if (stx != true && time <= 0)
        {
            VivrationSample(0, 0);
            stx = true;
        }
    }

    public void TimeVivration(float _a, float _b, float _time)
    {
        a = _a;
        b = _b;
        time = _time;
        sysTimeVivration(_a, _b);
    }
}
