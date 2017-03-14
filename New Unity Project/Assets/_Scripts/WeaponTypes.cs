using UnityEngine;
using System.Collections;

public class WeaponTypes : MonoBehaviour {
    int currentWeapon = 0;
    int WeaponSlot1;
    int WeaponSlot2;
    int WeaponInUse;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        switch (currentWeapon)
        {
            case 1:
                if (WeaponSlot1 > 0)
                    WeaponInUse = WeaponSlot1;
                else WeaponInUse = 0;
                break;
            case 2:
                if (WeaponSlot2 > 0)
                    WeaponInUse = WeaponSlot2;
                else WeaponInUse = 0;
                break;
            default:
                WeaponInUse = 0;
                break;
        }
	}
public int GetWeapon()
{
    return WeaponInUse;
}
}
