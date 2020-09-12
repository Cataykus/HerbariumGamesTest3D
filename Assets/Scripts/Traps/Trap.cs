using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Trap : MonoBehaviour
{
    [SerializeField] private float _timer;

    private void Start()
    {
        StartCoroutine(StartAction());
    }

    private IEnumerator StartAction()
    {
        var wait = new WaitForSeconds(_timer);

        while (true)
        {
            yield return wait;

            Action();
        }
    }

    protected abstract void Action();
}
