using UnityEngine;
using System.Collections;

public class Enemyfollow : MonoBehaviour {
    public float EncounterMax;
    public float EncounterMin;
    public float FleeRange;
    GameObject PlayerRef;
    float PositiveX;
    float NegativeX;
    float PositiveY;
    float NegativeY;
    float MinimumPosX;
    float MinimumPosY;
    float MinimumNegX;
    float MinimumNegY;
    float MoveSpeed;
    public float Speed;
    // Use this for initialization
    void Start ()
    {
        PlayerRef = GameObject.Find("Prefab_Platform");
	
    }
	
	// Update is called once per frame
	void Update () {
    PositiveX = this.transform.position.x + EncounterMax;
    NegativeX = this.transform.position.x - EncounterMax;
    PositiveY = this.transform.position.y + EncounterMax;
    NegativeY = this.transform.position.y - EncounterMax;
    MinimumPosX = this.transform.position.x + EncounterMin;
    MinimumPosY = this.transform.position.y + EncounterMin;
    MinimumNegX = this.transform.position.x - EncounterMin;
    MinimumNegY = this.transform.position.y - EncounterMin;
        MoveSpeed = Time.deltaTime * Speed;
	if(PlayerRef.transform.position.x <= PositiveX && PlayerRef.transform.position.x >= NegativeX && PlayerRef.transform.position.y <= PositiveY && PlayerRef.transform.position.y >= NegativeY)
        {
           if (PlayerRef.transform.position.x > MinimumPosX || PlayerRef.transform.position.x < MinimumNegX && PlayerRef.transform.position.y > MinimumPosY || PlayerRef.transform.position.y < MinimumNegY)
           {
                transform.position = Vector3.MoveTowards(transform.position, PlayerRef.transform.position, MoveSpeed);
           }
        }
	}
}
