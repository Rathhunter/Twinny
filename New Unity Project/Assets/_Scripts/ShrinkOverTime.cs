using UnityEngine;
using System.Collections;

public class ShrinkOverTime : MonoBehaviour {

    public int StartScale;
    public int endscale;
    public float CurrentSize;
    public float Shrinkspeed;
    void Start()
    {
        CurrentSize = StartScale;
    }
    void Update()
    {
        CurrentSize -= Time.deltaTime * Shrinkspeed;
        this.transform.localScale = new Vector3(CurrentSize, CurrentSize, 0);
        if (CurrentSize <= 0)
            DestroyImmediate(this.gameObject);
    }
}
