using UnityEngine;
using System.Collections;

public class LaserFollow : MonoBehaviour {
    GameObject LegsRef;
	// Use this for initialization
	void Start () {
        LegsRef = GameObject.Find("Prefab_Platform");
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position = (LegsRef.transform.position + new Vector3(0,0,-0.1f));
	}
}
