using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Init_Game : MonoBehaviour
{
    public Button button;
    
    void Awake()
    {
       button.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        SceneManager.LoadScene("Startgame");
    }

}
