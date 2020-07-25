using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour
{
    public void MoveToMainScene()
    {
        OptionManager.optionCanvas.SetActive(false);

        // 임시
        GameManager.barSpeed = 4f;
        GameManager.ballSpeed = 300f;

        SceneManager.LoadScene("StageScene");
    }
}
