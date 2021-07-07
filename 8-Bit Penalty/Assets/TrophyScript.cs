using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrophyScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject[] trophyshadow;

    int totalgoal;
    void Start()
    {
        totalgoal = PlayerPrefs.GetInt("totalgoal");
    }

    public void checkgoals()
    {
        if (totalgoal >= 10)
        {
            trophyshadow[0].SetActive(false);
        } else if (totalgoal >= 12)
        {
            trophyshadow[1].SetActive(false);
        } else if (totalgoal >= 15)
        {
            trophyshadow[2].SetActive(false);
        }

    }

    public void returnscene()
    {
        SceneManager.LoadScene("Home");
    }

}
