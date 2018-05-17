using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearButton : MonoBehaviour {

    public bool notmoving;
    public GameObject gear;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
       
        if(notmoving)
        {

            HingeJoint gearhinge =(HingeJoint) gear.gameObject.GetComponent(typeof(HingeJoint));

            gearhinge.useMotor = true;

            notmoving = false;

        }

    }

}
