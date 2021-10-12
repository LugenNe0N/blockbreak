using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    //移動速度
    public float speed = 5f;
    Rigidbody playerRig;

    // Start is called before the first frame update
    void Start()
    {
        playerRig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRig.velocity = new Vector3(0, Input.GetAxis("Vertical2") * speed, 0);
    }
}
