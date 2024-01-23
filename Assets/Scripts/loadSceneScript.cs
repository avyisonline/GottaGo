using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadScene : MonoBehaviour
{
    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void loadLevel1()
    {
        SceneManager.LoadScene("Game1"); 
    }

    public void loadLevel2()
    {
        SceneManager.LoadScene("Game2");
    }

    public void loadLevel3()
    {
        SceneManager.LoadScene("Game3");
    }

    public void loadWin()
    {
        SceneManager.LoadScene("YouWin");
    }

    public void loadQuit()
    {
        SceneManager.LoadScene("Quit");
    }
}
