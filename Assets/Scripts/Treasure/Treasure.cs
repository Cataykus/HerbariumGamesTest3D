using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Treasure : MonoBehaviour
{
    public event UnityAction TreasureCollected;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out PlayerDie player))
        {
            TreasureCollected?.Invoke();
        }
    }
}
