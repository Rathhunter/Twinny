using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    public GameObject LegsRef;
    public GameObject BulletRef;
    public GameObject FirePoint;
    float reload;
    int WeaponUsed;
    public float firerate;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        WeaponUsed = LegsRef.GetComponent<WeaponTypes>().GetWeapon();
        firerate = LegsRef.GetComponent<FireRate>().GetFireRate();
        reload += Time.deltaTime;
        if(Input.GetAxis(LegsRef.GetComponent<Character>().GetRightTrigger()) < 0)
        {
            if (WeaponUsed == 1 && reload >= firerate)
            Instantiate(BulletRef, new Vector3(FirePoint.transform.position.x,FirePoint.transform.position.y, 0), this.transform.rotation);
            reload = 0;
        }
    }
}
