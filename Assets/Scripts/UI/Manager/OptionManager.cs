using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionManager : MonoBehaviour
{
    public static GameObject optionCanvas;
    public static OptionManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        optionCanvas = GameObject.Find("OptionCanvas");
        optionCanvas.SetActive(false);
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().ToString() == "MainScene")
        {
            TurnOnOptionMenu();
        }
    }

    public static void TurnOnOptionMenu()
    {
        Time.timeScale = 0f;
        optionCanvas.SetActive(true);
    }

    public static void TurnOffOptionMenu()
    {
        Time.timeScale = GameManager.timeScale;
        optionCanvas.SetActive(false);
    }
}
