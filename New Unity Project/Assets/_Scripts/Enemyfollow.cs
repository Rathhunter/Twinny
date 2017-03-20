using UnityEngine;
using System.Collections;

public class Enemyfollow : MonoBehaviour {
    public float EncounterMax;
    public float FollowRange;
    public float EncounterMin;
    public float FleeRange;
    GameObject PlayerRef;
    float MoveSpeed;
    float dist;
    public float Speed;
    bool Following = false;
    // Use this for initialization
    void Start ()
    {
        PlayerRef = GameObject.Find("Prefab_Platform");
	
    }
	
	// Update is called once per frame
	void Update () {
        MoveSpeed = Time.deltaTime * Speed;
        dist = Vector3.Distance(PlayerRef.transform.position, transform.position);
	if(dist <= FollowRange && Following == false)
        {
            Following = true;      
        }
    if (dist <= EncounterMax && dist >= EncounterMin && Following == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, PlayerRef.transform.position, MoveSpeed);
        }
        if (dist <= FleeRange && Following == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, PlayerRef.transform.position, -MoveSpeed);
          
        }
    }
}
