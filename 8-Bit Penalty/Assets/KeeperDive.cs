using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeeperDive : MonoBehaviour
{
    private Rigidbody2D rb;
    public float thrust = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        thrust = Random.Range(-2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void dive()
    {
        rb.AddForce(transform.right * thrust);
    }
}
