using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIRotateAnimation : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(Vector3.up * 50 * Time.deltaTime);
    }
}
