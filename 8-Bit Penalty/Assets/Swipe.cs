using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    Vector2 startPos, endPos, direction;
    float touchTimeStart, touchTimeFinish, timeInterval;
    int cekgol = 0;
    [Range(0.05f, 1f)]
    public float throwforce = 1f;

    private GameObject keeper;
    private KeeperDive kd;
    Animator playeranim;
    
    private void Start()
    {
        PlayerPrefs.SetInt("cekgol",0);
        playeranim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        playeranim.SetBool("shooted", false);
        keeper = GameObject.Find("Keeper1");
        kd = keeper.GetComponent<KeeperDive>();
    }

    void Update()
    {
        cekgol = PlayerPrefs.GetInt("cekgol");
        if (cekgol == 0)
        {
            //touch  the screen
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                touchTimeStart = Time.time; // get touch position and marking time when screen is touched
                startPos = Input.GetTouch(0).position;
            }

            //if finger released from screen
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                playeranim.SetBool("shooted", true);
                touchTimeFinish = Time.time; // marking time when release

                timeInterval = touchTimeFinish - touchTimeStart; //Calculate swipe time interval

                endPos = Input.GetTouch(0).position; // release finger position

                direction = startPos - endPos; //calculate swipe direction

                //add force
                GetComponent<Rigidbody2D>().AddForce(-direction / timeInterval * throwforce);

            }


            if (GetComponent<Rigidbody2D>().velocity != Vector2.zero)
            {
                playeranim.SetBool("shooted", false);
                kd.dive();
            }
        }
    }
}
