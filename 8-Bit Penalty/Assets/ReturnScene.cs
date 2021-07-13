using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReturnScene : MonoBehaviour
{
    public Animator transitionAnim;
    public void returnscene()
    {
        FindObjectOfType<AudioManager>().Play("UISound");
        StartCoroutine(LoadReturn());
    }

    public void soundpressed()
    {
        FindObjectOfType<AudioManager>().Play("UISound");
    }
    public void resetData()
    {
        transitionAnim.SetTrigger("End");
        FindObjectOfType<AudioManager>().Play("UISound");
        PlayerPrefs.SetInt("totalgoal", 0);
        PlayerPrefs.SetInt("streak", 0);
    }

    public IEnumerator LoadReturn()
    {
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene("Home");
    }
}
