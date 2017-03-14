using UnityEngine;
using System.Collections;

public class LaserFollow : MonoBehaviour {
    public GameObject LegsRef;
	// Use this for initialization
	void Start () {
        LegsRef = GameObject.Find("Legs");
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position = (LegsRef.transform.position + new Vector3(0,0,-0.1f));
	}
}
