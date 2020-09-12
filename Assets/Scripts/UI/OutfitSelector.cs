using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class OutfitSelector : MonoBehaviour
{
    [SerializeField] private Material _outfit;
    [SerializeField] private Transform _outfitStand;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(SelectOutfit);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(SelectOutfit);
        StopAllCoroutines();
    }

    private void SelectOutfit()
    {
        UserOutfit.Instance().SetOutfit(_outfit);
    }
}
