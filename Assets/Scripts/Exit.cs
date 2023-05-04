using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        PlayerPrefs.SetString("_last_scene_", "Level");
        SceneManager.LoadScene(0);
    }
}
