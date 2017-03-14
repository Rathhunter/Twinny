using UnityEngine;

public class Move : MonoBehaviour {
    public float speed = 5F;
    void Start()
    {
        AudioSource SkitterRef = GetComponent<AudioSource>();
        this.GetComponent<Character>().Setvariables();
        
    }
    void Update()
    {
        string PlayerHorizontal = this.GetComponent<Character>().GetHorizontal();
        string PlayerVertical = this.GetComponent<Character>().GetVertical();
        float translationY = Input.GetAxis(PlayerVertical) * speed;
        float translationX = Input.GetAxis(PlayerHorizontal) * speed;
        translationY *= Time.deltaTime;
        translationX *= Time.deltaTime;
        transform.Translate(translationX, translationY, 0);
    }
}
