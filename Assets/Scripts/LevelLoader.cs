using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelLoader : MonoBehaviour
{
    private GameObject _currentLevel = null;

    public event UnityAction LevelInitialized;

    private void Start()
    {
        LoadLevel(1);
    }

    private void LoadLevel(int level)
    {
        if(_currentLevel != null)
        {
            Destroy(_currentLevel);
        }

        _currentLevel = Instantiate(Resources.Load($"Levels/Level{level}") as GameObject);
        LevelInitialized?.Invoke();
    }
}
