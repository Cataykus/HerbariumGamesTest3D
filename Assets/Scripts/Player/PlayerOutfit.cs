using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class PlayerOutfit : MonoBehaviour
{
    private MeshRenderer _meshRenderer;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();

        var outfit = UserOutfit.Instance().Outfit;

        if (outfit != null)
        {
            _meshRenderer.material = outfit;
        }
    }
}
