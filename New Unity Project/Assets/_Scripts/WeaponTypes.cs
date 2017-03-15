using UnityEngine;
using System.Collections;

public class WeaponTypes : MonoBehaviour {
    int currentWeapon = 0;
    int WeaponSlot1;
    int WeaponSlot2;
    int WeaponInUse;
    string LeftBumper;
    string RightBumper;
    Component Character;
    
	// Use this for initialization
	void Start () {
        WeaponSlot1 = 1;
        WeaponSlot2 = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown(this.GetComponent<Character>().GetLeftBumper()))
        {
            currentWeapon -= 1;
            if (currentWeapon < 0)
                currentWeapon = 2;
        }
        if(Input.GetButtonDown(this.GetComponent<Character>().GetRightBumper()))
        {
            currentWeapon += 1;
            if (currentWeapon > 2)
                currentWeapon = 0;
        }
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



