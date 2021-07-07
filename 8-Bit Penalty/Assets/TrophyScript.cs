using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrophyScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject[] trophyshadow;

    int totalgoal = 0;
    void Start()
    {
        totalgoal = PlayerPrefs.GetInt("totalgoal");
        

        if (totalgoal >= 10)
        {
            trophyshadow[0].SetActive(false);
        }
        if (totalgoal >= 100)
        {
            trophyshadow[1].SetActive(false);
        }
        if (totalgoal >= 1000)
        {
            trophyshadow[2].SetActive(false);
        }

    }


    public void returnscene()
    {
        SceneManager.LoadScene("Home");
    }

}
