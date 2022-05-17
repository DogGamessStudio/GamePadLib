using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GamePadLi
{
    public class GetControllerName : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public String _GetControllerName()
        {
            return InputSystem.GetDevice<Gamepad>().displayName;
        } 
    }
}

