using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class SpikeTrap : Trap
{
    [SerializeField] private bool _isActive = false;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    protected override void Action()
    {
        if (_isActive)
        {
            _animator.Play("Close");
        }
        else
        {
            _animator.Play("Open");
        }

        _isActive = !_isActive;
    }
}
