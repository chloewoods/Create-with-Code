using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    
    public void OnButtonPress(string buttonValue)
    {
        switch (buttonValue)
        {
            case "Laboratory":
                {
                    SceneManager.LoadScene("Prototype 2");
                    Debug.Log("Pressd");
                    break;
                }
            case "Challenge":
                {
                    SceneManager.LoadScene("Challenge 2");
                    break;
                }
            case "Exit":
                {
                    Application.Quit();
                    break;
                }
            default:
                {
                    break;
                }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
