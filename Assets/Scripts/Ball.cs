using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //ボールの移動速度
    public float speed = 10f;
    public float minSpeed = 10f;
    public float maxSpeed = 20f;
    Rigidbody ballRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
        ballRigidbody.velocity = new Vector3(speed, speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // 現在の速度を取得
        Vector3 velocity = ballRigidbody.velocity;
        // 速さを計算
        float clampedSpeed = Mathf.Clamp(velocity.magnitude, minSpeed, maxSpeed);
        // 速度を変更
        ballRigidbody.velocity = velocity.normalized * clampedSpeed;
    }
}
