using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGoal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject go;
    int cekgol = 0;
    private RipplePostProcessor camRipple;
    
    void Start()
    {
        camRipple = Camera.main.GetComponent<RipplePostProcessor>();
        
    }

    

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.name.Equals("Blueball"))
        {
            
            go.SetActive(true);
            PlayerPrefs.SetInt("cekgol", 1);
            camRipple.RippleEffect();
            

        }

    }
}
