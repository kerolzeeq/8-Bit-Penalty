using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OutGoal : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameObject tap2restart;

    [SerializeField]
    GameObject NoGoalText;

    int streak = 0;
    bool goal;
    void Start()
    {
        streak = PlayerPrefs.GetInt("streak");
        

        
    }

    private void Update()
    {
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

            PlayerPrefs.SetInt("streak", 0);
            NoGoalText.SetActive(true);
            tap2restart.SetActive(true);
            goal = true;

        }

    }

    public IEnumerator StartWait(float countdownValue = 10)
    {

        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("Penalty");
    }
}
