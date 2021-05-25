using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GodSelector : MonoBehaviour
{
    public Gods god;
    public int godNumber;
    
    void Start()
    {
        GetComponent<Image>().sprite = god.godImage;
        
    }
    public void ChangeGod()
    {
        godNumber = god.godID;
        PlayerPrefs.SetInt("SelectedGod", godNumber);
        SceneManager.LoadScene("MainScene");
        //FindObjectOfType<GameFlowController>().loadScene("MainScene");
        //FindObjectOfType<PlayerCharecterStats>().currentSelectedGod = god;
    }
   
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
