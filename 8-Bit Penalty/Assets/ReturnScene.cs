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
}
