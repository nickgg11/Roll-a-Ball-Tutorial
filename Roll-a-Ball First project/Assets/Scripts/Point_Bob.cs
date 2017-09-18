using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_Bob : MonoBehaviour {
    private Rigidbody rb;
    public float bump=0.5f;
    private float timer = 0f;
    Vector3 bounce;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        bounce = new Vector3(0, bump, 0);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        timer += Time.deltaTime;
        if (timer > 3)
        {
            
            rb.AddForce(bounce , ForceMode.Impulse);
            timer = 0;
        }
            
        
        
	}
}
