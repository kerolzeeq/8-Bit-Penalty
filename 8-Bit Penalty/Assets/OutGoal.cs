using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OutGoal : MonoBehaviour
{
    // Start is called before the first frame update

    int streak = 0;
    void Start()
    {
        streak = PlayerPrefs.GetInt("streak");
    }


    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.name.Equals("Blueball"))
        {

            PlayerPrefs.SetInt("streak", 0);
            SceneManager.LoadScene("Penalty");

        }

    }
}
