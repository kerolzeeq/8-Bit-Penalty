using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    
    int currentSceneIndex;
    Animator titleanim,textanim,ballanim;

    public Animator transitionAnim;
    private void Start()
    {
        StartCoroutine(StartWait());
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        textanim = GameObject.Find("Tap2Play").GetComponent<Animator>();
        titleanim = GameObject.Find("Title").GetComponent<Animator>();
        ballanim = GameObject.Find("Blueball").GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        {
            float y = Screen.height / 5;
            if (Input.mousePosition.y >= y)
            {
                textanim.SetBool("exit", true);
                titleanim.SetBool("exit", true);
                ballanim.SetBool("exit", true);
                StartCoroutine(StartCountdown());
            }
        }
    }

    void LoadNextLevel()
    {
        FindObjectOfType<AudioManager>().Play("UISound");
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    float currCountdownValue;
    public IEnumerator StartCountdown(float countdownValue = 10)
    {
        currCountdownValue = countdownValue;
        transitionAnim.SetTrigger("End");
        while (currCountdownValue > 0)
        {
            yield return new WaitForSeconds(0.9f);
            currCountdownValue--;
        }
        LoadNextLevel();
    }

    public IEnumerator StartWait(float countdownValue = 10)
    {
 
            yield return new WaitForSeconds(0.5f);
            
    }

    public void MoveTrophyRoomScene()
    {
        FindObjectOfType<AudioManager>().Play("UISound");
        StartCoroutine(LoadMoveTrophy());
    }
    public IEnumerator LoadMoveTrophy()
    {
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene("TrophyRoom");
    }
    public void SettingsScene()
    {
        FindObjectOfType<AudioManager>().Play("UISound");
        StartCoroutine(LoadSettings());
    }
    public IEnumerator LoadSettings()
    {
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene("Settings");
    }

    public void InstructionsScene()
    {
        FindObjectOfType<AudioManager>().Play("UISound");
        StartCoroutine(LoadInstructions());
    }
    public IEnumerator LoadInstructions()
    {
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene("Instructions");
    }
}
