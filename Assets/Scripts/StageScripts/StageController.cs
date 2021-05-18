using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    public List<Stages> stageList;

    public static Boss currentBoss;
    public static Enemies currentEnemy;
    public static Sprite currentBackground;
    public static float killsNeededForBoss;

    public static int stageCounter;
    public GameObject changeBackground;


    public void GetStageInfo()
    {
        currentBoss = stageList[stageCounter].stageBoss;
        currentEnemy = stageList[stageCounter].stageEnemy;
        currentBackground = stageList[stageCounter].backgroundImage;
        killsNeededForBoss = stageList[stageCounter].killsForBoss;
        //print(currentBoss);
        //print(currentEnemy);
        //print(currentBackground);
    }



    public void ResetPlayerPref()
    {
        PlayerPrefs.DeleteAll();
    }


    void Start()
    {
        stageCounter = PlayerPrefs.GetInt("Stage");
        GetStageInfo();
        changeBackground.GetComponent<SpriteRenderer>().sprite = currentBackground;
        //print("Estas en el stage " + stageCounter);
    }

    // Update is called once per frame
    void Update()
    {
        GetStageInfo();
        //print(stageCounter);
    }
}
