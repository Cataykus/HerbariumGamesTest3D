using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private LevelLoader _levelLoader;
    [SerializeField] private GameObject _defeatPanel;
    [SerializeField] private GameObject _victoryPanel;

    private PlayerDie _playerDie;
    private Treasure _treasure;

    private void OnEnable()
    {
        _levelLoader.LevelInitialized += OnLevelInitialized;
    }

    private void OnDisable()
    {
        _levelLoader.LevelInitialized -= OnLevelInitialized;
    }

    private void OnLevelInitialized()
    {
        _playerDie = FindObjectOfType<PlayerDie>();
        _treasure = FindObjectOfType<Treasure>();

        _playerDie.PlayerDied += OnPlayerDied;
        _treasure.TreasureCollected += OnTreasureCollected;
    }

    private void OnPlayerDied()
    {
        _defeatPanel.SetActive(true);
        Time.timeScale = 0;
    }

    private void OnTreasureCollected()
    {
        _victoryPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
