using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(BoxCollider))]
public class FloorTrap : Trap
{
    [SerializeField] private bool _isActive = false;

    private MeshRenderer _meshRenderer;
    private BoxCollider _boxCollider;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _boxCollider = GetComponent<BoxCollider>();
    }

    protected override void Action()
    {
        if (_isActive)
        {
            _meshRenderer.enabled = false;
            _boxCollider.enabled = false;
        }
        else
        {
            _meshRenderer.enabled = true;
            _boxCollider.enabled = true;
        }

        _isActive = !_isActive;
    }
}
