using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReturnScene : MonoBehaviour
{
    public void returnscene()
    {
        SceneManager.LoadScene("Home");
    }

    public void resetData()
    {
        PlayerPrefs.SetInt("totalgoal", 0);
        PlayerPrefs.SetInt("streak", 0);
    }
}
