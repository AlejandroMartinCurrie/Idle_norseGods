using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextStage : MonoBehaviour
{

    void Update()
    {
        if(BossConrtoller.bossStageCleared)
        {
            BossConrtoller.bossStageCleared = false;
            FindObjectOfType<GameFlowController>().loadScene("MainScene");
        }
    }
}
