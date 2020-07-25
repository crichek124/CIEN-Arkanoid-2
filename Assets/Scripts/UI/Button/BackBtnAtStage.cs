using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackBtnAtStage : MonoBehaviour
{
    public void MoveToStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
