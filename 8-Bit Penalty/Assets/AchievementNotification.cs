using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementNotification : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] trophy;
    public GameObject noti;
    int totalgoal;
    void Start()
    {
        totalgoal = PlayerPrefs.GetInt("totalgoal");
        noti.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (totalgoal == 10)
        {
            noti.SetActive(true);
            trophy[0].SetActive(true);
            trophy[1].SetActive(false);
            trophy[2].SetActive(false);
        } else if (totalgoal == 100)
        {
            noti.SetActive(true);
            trophy[0].SetActive(false);
            trophy[1].SetActive(true);
            trophy[2].SetActive(false);
        } else if (totalgoal == 1000)
        {
            noti.SetActive(true);
            trophy[0].SetActive(false);
            trophy[1].SetActive(false);
            trophy[2].SetActive(true);
        }
        else
        {
            noti.SetActive(false);
            trophy[0].SetActive(true);
        }
    }
}
