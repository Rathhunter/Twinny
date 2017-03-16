using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    GameObject LegsRef;
    public GameObject BulletRef;
    public GameObject FirePoint;
    public GameObject FirePoint1;
    public GameObject FirePoint2;
    public GameObject FirePoint3;
    public GameObject FirePoint4;
    float reload;
    bool TractorUse;
    int WeaponUsed;
    GameObject VacuumRef;
    public float firerate;
	// Use this for initialization
	void Start () {
        LegsRef = GameObject.Find("Prefab_Platform");
        if (this.tag == "LaserTag")
        {
            WeaponUsed = 1;
        }
        if (this.tag == "ShottyTag")
        {
            WeaponUsed = 2;
        }
        if (this.tag == "TractorTag")
        {
            WeaponUsed = 0;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        firerate = LegsRef.GetComponent<FireRate>().GetFireRate();
        reload += Time.deltaTime;
        if(Input.GetAxis(LegsRef.GetComponent<Character>().GetRightTrigger()) < 0)
        {
            Debug.Log("send help");
            if (WeaponUsed == 1 && reload >= firerate)
            {
                Instantiate(BulletRef, new Vector3(FirePoint.transform.position.x, FirePoint.transform.position.y, 0), this.transform.rotation);
                reload = 0;
            }
            if (WeaponUsed == 0 && TractorUse == false)
            {
                TractorUse = true;
                VacuumRef = (GameObject)Instantiate(BulletRef, new Vector3(FirePoint.transform.position.x, FirePoint.transform.position.y, 0), this.transform.rotation);
            }
            if (WeaponUsed == 2 && reload >= firerate)
            {
                Instantiate(BulletRef, new Vector3(FirePoint1.transform.position.x, FirePoint1.transform.position.y, 0), FirePoint1.transform.rotation);
                Instantiate(BulletRef, new Vector3(FirePoint2.transform.position.x, FirePoint2.transform.position.y, 0), FirePoint2.transform.rotation);
                Instantiate(BulletRef, new Vector3(FirePoint3.transform.position.x, FirePoint3.transform.position.y, 0), FirePoint3.transform.rotation);
                Instantiate(BulletRef, new Vector3(FirePoint4.transform.position.x, FirePoint4.transform.position.y, 0), FirePoint4.transform.rotation);
                reload = 0;
            }
        }
        if (Input.GetAxis(LegsRef.GetComponent<Character>().GetRightTrigger()) == 0)
        {
            if (WeaponUsed == 0 && TractorUse == true)
            {
                TractorUse = false;
                DestroyImmediate(VacuumRef);
            }
        }
    }
    public int GetWeap()
    {
        return WeaponUsed;
    }
}
