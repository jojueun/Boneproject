using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveimput : MonoBehaviour
{
    //�� �Ʒ��� �ۼ��� �ڵ�� �����Ϳ� �ش��ϴ� �����Դϴ�.
    public float moveSpeed = 5f;
    public Rigidbody2D rigid;
    //
    private void Update()
    {
        // Update is called once per frame
        float h = Input.GetAxis("Horizontal");

        rigid.velocity = new Vector2(h * moveSpeed, 0);
    }
}
