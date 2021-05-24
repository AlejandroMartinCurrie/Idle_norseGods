using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodsCanvasController : MonoBehaviour
{

    public GameObject godsCanvas;
    public bool godsCanvasActive;



    public void ActivateGodsCanvas()
    {
        if (godsCanvasActive)
        {
            godsCanvas.SetActive(false);
            godsCanvasActive = false;
        }
        else
        {
            godsCanvas.SetActive(true);
            godsCanvasActive = true;
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
