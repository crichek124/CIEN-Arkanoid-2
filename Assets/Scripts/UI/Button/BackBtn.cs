using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackBtn : MonoBehaviour
{
    public void MoveToStartScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartScene");
    }
}
