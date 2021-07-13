using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckGoal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject go;
    int cekgol = 0;
    private RipplePostProcessor camRipple;

    int totalgoal = 0, streak = 0;

    [SerializeField]
    Text streakText;

    [SerializeField]
    Text totalgoalText;

    [SerializeField]
    GameObject tap2restart;

    [SerializeField]
    GameObject GoalText;

    bool goal;

    void Start()
    {
        //PlayerPrefs.SetInt("totalgoal", 0);
        //PlayerPrefs.SetInt("streak", 0);
        //totalgoal = 0; streak = 0;
        goal = false;
        totalgoal = PlayerPrefs.GetInt("totalgoal");
        streak = PlayerPrefs.GetInt("streak");

        camRipple = Camera.main.GetComponent<RipplePostProcessor>();
        
    }

    private void Update()
    {
        totalgoal = PlayerPrefs.GetInt("totalgoal");
        streak = PlayerPrefs.GetInt("streak");
        streakText.text = "Goal Streak: " + streak;
        totalgoalText.text = "Total Goals: " + totalgoal;

        if (goal && Input.touchCount > 0)
        {
            StartCoroutine(StartWait());
            goal = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.name.Equals("Blueball"))
        {
            totalgoal++;
            streak++;
            PlayerPrefs.SetInt("totalgoal",totalgoal);
            PlayerPrefs.SetInt("streak", streak);
            go.SetActive(true);
            PlayerPrefs.SetInt("cekgol", 1);
            camRipple.RippleEffect();
            tap2restart.SetActive(true);
            GoalText.SetActive(true);

            goal = true;
            
            


        }

    }

    public IEnumerator StartWait(float countdownValue = 10)
    {

        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("Penalty");
    }

    public void returnscene()
    {
        SceneManager.LoadScene("Home");
    }

}
