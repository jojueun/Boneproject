using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public float fallingSpeed = 5f;
    public Rigidbody2D rigid;

    // Update is called once per frame
    void Update()
    {
        rigid.velocity = Vector2.down * fallingSpeed;
    }
}
