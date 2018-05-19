using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour {
    public float blow;
    private void OnTriggerStay(Collider other)
    {
        other.GetComponent<Rigidbody>().AddForce(Vector3.forward * blow, ForceMode.Acceleration);
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
