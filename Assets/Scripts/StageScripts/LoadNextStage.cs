using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextStage : MonoBehaviour
{

    void Update()
    {
        if(BossController.bossStageCleared)
        {
            BossController.bossStageCleared = false;
            FindObjectOfType<GameFlowController>().loadScene("MainScene");
        }
    }
}
