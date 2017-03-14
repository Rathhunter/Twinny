using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletMove : MonoBehaviour {
    float speed;
    public float actualspeed = 5f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Rigidbody2D>().velocity = transform.up * actualspeed;
    }
}
