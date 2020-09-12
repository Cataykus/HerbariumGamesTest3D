using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private float _smoothness = 5;    

    private Transform _target;

    private void Update()
    {
        if(_target == null)
        {
            try
            {
                _target = FindObjectOfType<PlayerMover>().GetComponent<Transform>();
            }
            catch (System.Exception)
            {
                return;
            }
        }

        float x = Mathf.Lerp(transform.position.x, _target.position.x, _smoothness * Time.deltaTime);
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
