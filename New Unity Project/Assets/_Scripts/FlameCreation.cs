using UnityEngine;
using System.Collections;

public class FlameCreation : MonoBehaviour {
    GameObject PlayerRef;
    public GameObject FlamesRef;
    bool left;
    bool right;
    bool up;
    bool down;
	// Use this for initialization
	void Start () {
        left = false;
        right = false;
        up = false;
        down = false;
	}
	public bool GetLeft()
    {
        return left;
    }
    public bool GetRight()
    {
        return right;
    }
    public bool GetUp()
    {
        return up;
    }
    public bool GetDown()
    {
        return down;
    }

	// Update is called once per frame
	void Update () {
        string PlayerHorizontal = this.GetComponent<Character>().GetHorizontal();
        string PlayerVertical = this.GetComponent<Character>().GetVertical();
        


        
            if (Input.GetAxis(PlayerHorizontal) > 0 && left == false)
            {
                Instantiate(FlamesRef, (this.transform.position + new Vector3(-0.01f, 0f, 0.1f)), Quaternion.Euler(0, 0, 270));
                left = true;
                right = false;
            }
            if (Input.GetAxis(PlayerHorizontal) < 0 && right == false)
            {
                Instantiate(FlamesRef, (this.transform.position + new Vector3(0.01f, 0f, 0.1f)), Quaternion.Euler(0, 0, 90));
                left = false;
                right = true;
            }

            if (Input.GetAxis(PlayerVertical) > 0 && up == false)
            {
            Instantiate(FlamesRef, (this.transform.position + new Vector3(0, -0.01f, 0.1f)), Quaternion.Euler(0, 0, 180));
            up = true;
            down = false;
        }
            if (Input.GetAxis(PlayerVertical) < 0 && down == false)
            {
                Instantiate(FlamesRef, (this.transform.position + new Vector3(0, 0.01f, 0.1f)), Quaternion.Euler(0, 0, 180));
                up = false;
                down = true;
            }
            if (Input.GetAxis(PlayerVertical) == 0)
            {
                up = false;
                down = false;
            }
            if (Input.GetAxis(PlayerHorizontal) == 0)
            {
                left = false;
                right = false;
            }
        Debug.Log(down);
        }
    
}
