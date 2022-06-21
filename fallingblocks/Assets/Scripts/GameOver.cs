using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public GameObject gameOverScreen;
    public TextMeshProUGUI secondsSurvivedUI;
    bool gameOver;

    void Start() {

        FindObjectOfType<PlayerControls>().OnPlayerDeath += OnGameOver;

    }

    // Update is called once per frame
    void Update() {

        if (gameOver) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                SceneManager.LoadScene(0);
            }
        }

    }

    void OnGameOver() {
        gameOverScreen.SetActive(true);
        secondsSurvivedUI.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
        gameOver = true;
    }
}
