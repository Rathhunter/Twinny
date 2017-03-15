using UnityEngine;
using System.Collections;

public class LaserRotate : MonoBehaviour {
    public float rotationSpeed = 100.0F;
    GameObject LegsRef;
    // Use this for initialization
    void Start () {
        LegsRef = GameObject.Find("Prefab_Platform");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis(LegsRef.GetComponent<Character>().GetRightX()) > 0 || Input.GetAxis(LegsRef.GetComponent<Character>().GetRightX()) < 0 || Input.GetAxis(LegsRef.GetComponent<Character>().GetRightY()) > 0 || Input.GetAxis(LegsRef.GetComponent<Character>().GetRightY()) < 0)
        {
            float angle = Mathf.Atan2(Input.GetAxis(LegsRef.GetComponent<Character>().GetRightX()), Input.GetAxis(LegsRef.GetComponent<Character>().GetRightY())) * Mathf.Rad2Deg;
            this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }
    }
}
