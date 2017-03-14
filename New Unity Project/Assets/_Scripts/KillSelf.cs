using UnityEngine;
using System.Collections;

public class KillSelf : MonoBehaviour {
    public float timer;
    private float countdown;
    
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, timer);
        countdown = timer;
	}
	
	// Update is called once per frame
	void Update () {
        countdown -= Time.deltaTime;
	}
}
