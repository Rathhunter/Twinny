using UnityEngine;
using System.Collections;

public class CollideKill : MonoBehaviour {

    void Start()
    {
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "EnemyTag")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
     }
}