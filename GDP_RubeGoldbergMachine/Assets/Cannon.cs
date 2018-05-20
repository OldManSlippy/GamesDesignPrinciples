using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Rigidbody ball;
    private void OnTriggerEnter(Collider other)
    {
            ball.AddForce(new Vector3(500, 0, 0), ForceMode.Acceleration);

    }
}
