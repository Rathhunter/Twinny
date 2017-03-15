using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    GameObject LegsRef;
    public GameObject BulletRef;
    public GameObject FirePoint;
    float reload;
    bool TractorUse;
    int WeaponUsed;
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
                Debug.Log(TractorUse);
            }
        }
        if (Input.GetAxis(LegsRef.GetComponent<Character>().GetRightTrigger()) == 0)
        {
            if (WeaponUsed == 0 && TractorUse == true)
            {
                TractorUse = false;
                Debug.Log(TractorUse);
            }
        }
    }
    public int GetWeap()
    {
        return WeaponUsed;
    }
}
