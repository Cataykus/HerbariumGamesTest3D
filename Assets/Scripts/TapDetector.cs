using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapDetector : MonoBehaviour
{
    public event Action<Vector3> TapDetected;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int middleOfScreen = Screen.width / 2;

            if(Input.mousePosition.x > middleOfScreen)
            {
                TapDetected?.Invoke(Vector3.right);
            }
            else
            {
                TapDetected?.Invoke(Vector3.left);
            }
        }
    }
}
