using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class OutfitSelector : MonoBehaviour
{
    [SerializeField] private Material _outfit;
    [SerializeField] private Transform _outfitStand;
    [SerializeField] private bool _isStandart;

    private Button _button;
    private bool _isSelected = false;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(SelectOutfit);

        if (_isStandart)
        {
            SelectOutfit();
        }
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(SelectOutfit);
        StopAllCoroutines();
    }

    private void SelectOutfit()
    {
        OutfitSelector[] selectors = FindObjectsOfType<OutfitSelector>();

        foreach (var item in selectors)
        {
            item.Deselect();
        }

        _isSelected = true;
        UserOutfit.Instance().SetOutfit(_outfit);
        StartCoroutine(RotateAnimation());
    }

    public void Deselect()
    {
        StopAllCoroutines();
        _isSelected = false;
        _outfitStand.rotation = Quaternion.Euler(Vector3.zero);
    }

    private IEnumerator RotateAnimation()
    {
        var wait = new WaitForEndOfFrame();

        while (true)
        {
            _outfitStand.Rotate(Vector3.up * 50 * Time.deltaTime);
            yield return wait;
        }
    }
}
