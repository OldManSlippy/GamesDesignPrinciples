using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolineleft : MonoBehaviour {
    float trampoline = 12;
    public Rigidbody actor;
    void Start()
    {
        actor = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "TrampolineLeft")
        {
            actor.velocity = new Vector3(0, trampoline, -trampoline);

        }
    }
}
