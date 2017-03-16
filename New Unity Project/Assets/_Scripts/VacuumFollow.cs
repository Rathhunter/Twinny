using UnityEngine;
using System.Collections;

public class VacuumFollow : MonoBehaviour {
    GameObject VacuumPointRef;
	// Use this for initialization
	void Start () {
        VacuumPointRef = GameObject.Find("VacuumPoint");
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = (VacuumPointRef.transform.position + new Vector3(0,0,-0.1f));
        this.transform.rotation = VacuumPointRef.transform.rotation;
	}
}
