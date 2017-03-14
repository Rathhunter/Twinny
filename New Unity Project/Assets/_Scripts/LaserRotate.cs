using UnityEngine;
using System.Collections;

public class LaserRotate : MonoBehaviour {
    public float rotationSpeed = 100.0F;
    GameObject PlayerRef;
    // Use this for initialization
    void Start () {
        PlayerRef = GameObject.Find("Legs");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis(PlayerRef.GetComponent<Character>().GetRightX()) > 0 || Input.GetAxis(PlayerRef.GetComponent<Character>().GetRightX()) < 0 || Input.GetAxis(PlayerRef.GetComponent<Character>().GetRightY()) > 0 || Input.GetAxis(PlayerRef.GetComponent<Character>().GetRightY()) < 0)
        {
            float angle = Mathf.Atan2(Input.GetAxis(PlayerRef.GetComponent<Character>().GetRightX()), Input.GetAxis(PlayerRef.GetComponent<Character>().GetRightY())) * Mathf.Rad2Deg;
            this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }
    }
}
