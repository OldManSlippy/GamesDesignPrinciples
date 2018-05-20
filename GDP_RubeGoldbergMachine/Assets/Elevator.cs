using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {
    public GameObject lift;
    public int time = 10;
    private bool on = false;
    private void OnTriggerEnter(Collider other)
    {
            on = true;
    }
	void Update ()
    {
        if (time >= 0)
        {
            if (on == true)
            {
                Vector3 pos = lift.transform.position;
                lift.transform.position = new Vector3(pos.x,pos.y + 1,pos.z);
                time --;
            }
        }
	}
}