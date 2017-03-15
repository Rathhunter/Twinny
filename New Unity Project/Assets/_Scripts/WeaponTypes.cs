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

        this.GetComponent<Character>().GetLeftBumper();
        this.GetComponent<Character>().GetRightBumper();
	}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown(this.GetComponent<Character>().GetLeftBumper()))
        {
            Debug.Log("LeftBumper");
        }
        if(Input.GetButtonDown(this.GetComponent<Character>().GetRightBumper()))
        {
            Debug.Log("RightBumper");
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



