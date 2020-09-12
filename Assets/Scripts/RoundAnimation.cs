using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundAnimation : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed = 5f;
        
    private void Update()
    {
        transform.Rotate(Vector3.forward * _rotateSpeed * Time.deltaTime);
    }
}
