using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveimput : MonoBehaviour
{
    //이 아래에 작성한 코드는 데이터에 해당하는 영역입니다.
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
