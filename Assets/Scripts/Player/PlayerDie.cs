using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class PlayerDie : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public event UnityAction PlayerDied;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(_rigidbody.velocity.y < -10)
        {
            Die();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.TryGetComponent(out Trap trap))
        {
            Die();
        }
    }

    private void Die()
    {
        PlayerDied?.Invoke();
    }
}
