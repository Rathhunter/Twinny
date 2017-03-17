using UnityEngine;
using System.Collections;

public class Enemyfollow : MonoBehaviour {
    public int EncounterMax;
    public int EncounterMin;
    public int FleeRange;
    GameObject PlayerRef;
    float PositiveX;
    float NegativeX;
    float PositiveY;
    float NegativeY;
    float MinimumPosX;
    float MinimumPosY;
    float MinimumNegX;
    float MinimumNegY;
    // Use this for initialization
    void Start ()
    {
        PlayerRef = GameObject.Find("Prefab_Platform");
	PositiveX = this.transform.position.x + EncounterMax;
    NegativeX = this.transform.position.x - EncounterMax;
    PositiveY = this.transform.position.y + EncounterMax;
    NegativeY = this.transform.position.y - EncounterMax;
    MinimumPosX = this.transform.position.x + EncounterMin;
    MinimumPosY = this.transform.position.y + EncounterMin;
    MinimumNegX = this.transform.position.x - EncounterMin;
    MinimumNegY = this.transform.position.y - EncounterMin;
    }
	
	// Update is called once per frame
	void Update () {
	if(PlayerRef.transform.position.x <= PositiveX && PlayerRef.transform.position.x >= MinimumPosX && PlayerRef.transform.position.y <= PositiveY && PlayerRef.transform.position.y >= MinimumPosY)
        {

        }
	}
}
