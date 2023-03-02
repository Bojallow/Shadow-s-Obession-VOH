using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState State;

    public static event Action<GameState> OnGameStateChanged;

    void Awake() {
        Instance = this;
    }

    void Start() {
        UpdateGameState(GameState.StartGame);
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateGameState(GameState newState) {
        State = newState;

        switch (newState) {
            case GameState.GameOver:
                break;
            case GameState.LeftWing:
                break;
            case GameState.MainWing:
                break;
            case GameState.NorthWing:
                break;
            case GameState.RightWing:
                break;
            case GameState.StartGame:
                break;
            case GameState.Victory:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnGameStateChanged?.Invoke(newState);
    }
}

public enum GameState { 
    StartGame,
    MainWing,
    LeftWing,
    RightWing,
    NorthWing,
    Victory,
    GameOver
};
