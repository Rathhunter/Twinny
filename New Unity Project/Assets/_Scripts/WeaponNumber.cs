using UnityEngine;
using System.Collections;

public class WeaponNumber : MonoBehaviour {
    public int Weapon;
    GameObject LegsRef;
	// Use this for initialization
	void Start () {
        LegsRef = GameObject.Find("Prefab_Platform");
    }
	
	// Update is called once per frame
	void Update () {

	}
}
