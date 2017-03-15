using UnityEngine;
using System.Collections;

public class GunSwitch : MonoBehaviour {
    GameObject LegsRef;
    GameObject LaserRef;
    GameObject ShottyRef;
    GameObject VacuumRef;
	// Use this for initialization
	void Start () {
        LegsRef = GameObject.Find("Prefab_Platform");
        LaserRef = GameObject.Find("Prefab_Laser");
        ShottyRef = GameObject.Find("Prefab_Shotty");
        VacuumRef = GameObject.Find("Prefab_Vacuum");
    }
	
	// Update is called once per frame
	void Update () {
        if (LegsRef.GetComponent<WeaponTypes>().GetWeapon() != 0)
            VacuumRef.gameObject.SetActive(false);
        else VacuumRef.gameObject.SetActive(true);
        if (LegsRef.GetComponent<WeaponTypes>().GetWeapon() != 1)
            LaserRef.gameObject.SetActive(false);
        else LaserRef.gameObject.SetActive(true);
        if (LegsRef.GetComponent<WeaponTypes>().GetWeapon() != 2)
            ShottyRef.gameObject.SetActive(false);
        else ShottyRef.gameObject.SetActive(true);
    }
}
