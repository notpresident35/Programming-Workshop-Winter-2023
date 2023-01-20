using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float TargetY;
    public float MoveSpeed;
    public float MinX;
    public float MaxX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.down * Time.deltaTime * MoveSpeed;
    }
}
