using UnityEngine;
using System.Collections;

public class FlameFollow : MonoBehaviour {
    GameObject LegsRef;
    bool left;
    bool right;
    bool up;
    bool down;
    string opposite;
    Vector3 Position;
    float scale = 0.5f;
    float minScale = 0.5f;
    float maxScale = 1.0f;
    float scaleSpeed = 0.5f;
    // Use this for initialization
    void Start()
    {
        LegsRef = GameObject.Find("Prefab_Platform");
        right = LegsRef.GetComponent<FlameCreation>().GetRight();
        left = LegsRef.GetComponent<FlameCreation>().GetLeft();
        up = LegsRef.GetComponent<FlameCreation>().GetUp();
        down = LegsRef.GetComponent<FlameCreation>().GetDown();

        if(this.transform.position == (LegsRef.transform.position+new Vector3(0.01f,0,0.1f)))
        {
           
            Position = new Vector3(0.41f, 0f, 0.1f);
            opposite = "left";
        }

        if (this.transform.position == (LegsRef.transform.position + new Vector3(-0.01f, 0, 0.1f)))
        {
            
            Position = new Vector3(-0.41f, 0f, 0.1f);
            opposite = "right";
        }

        if (this.transform.position == (LegsRef.transform.position + new Vector3(0f, -0.01f, 0.1f)))
        {
            
                Position = new Vector3(0, -0.41f, 0.1f);
            opposite = "down";
        }

        if (this.transform.position == (LegsRef.transform.position + new Vector3(0, 0.01f, 0.1f)))
        {
            
                Position = new Vector3(0, 0.41f, 0.1f);
            opposite = "up";
        }

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = (LegsRef.transform.position + Position);
        if(opposite == "left")
        {
            right = LegsRef.GetComponent<FlameCreation>().GetRight();
            left = LegsRef.GetComponent<FlameCreation>().GetLeft();
            scale += scaleSpeed * Time.deltaTime;
            maxScale = Input.GetAxis(LegsRef.GetComponent<Character>().GetHorizontal());
            if (scale > maxScale)
            {
                scale = maxScale;
            }
            this.transform.localScale = new Vector3(scale, scale, 0);
            this.transform.rotation = Quaternion.Euler(0, 0, 270);
            if (right == false || left == true)
            {
                DestroyImmediate(this.gameObject);
            }
        }
        if (opposite == "right")
        {
            left = LegsRef.GetComponent<FlameCreation>().GetLeft();
            right = LegsRef.GetComponent<FlameCreation>().GetRight();
            scale = -Input.GetAxis(LegsRef.GetComponent<Character>().GetHorizontal());        
            this.transform.localScale = new Vector3(scale, scale, 0);
            this.transform.rotation = Quaternion.Euler(0, 0, 90);
            if (left == false || right == true)
            {
                DestroyImmediate(this.gameObject);
            }
        }
        if (opposite == "down")
        {
            up = LegsRef.GetComponent<FlameCreation>().GetUp();
            scale = -Input.GetAxis(LegsRef.GetComponent<Character>().GetVertical());
            this.transform.localScale = new Vector3(scale, scale, 0);
            this.transform.rotation = Quaternion.Euler(0, 0, 180);
            if (up == false)
            {
                DestroyImmediate(this.gameObject);
            }
        }
        if (opposite == "up")
        {
            down = LegsRef.GetComponent<FlameCreation>().GetDown();
            scale = Input.GetAxis(LegsRef.GetComponent<Character>().GetVertical());

            this.transform.localScale = new Vector3(scale, scale, 0);
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
            if (down == false)
            {
                DestroyImmediate(this.gameObject);
            }
        }

    }
}
