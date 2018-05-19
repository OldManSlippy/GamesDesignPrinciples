using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearButton : MonoBehaviour {

    public bool notmoving;
    public GameObject Gear;
    public GameObject Gear2;
    private void OnTriggerEnter(Collider other)
    {
        if(notmoving)
        {
            notmoving = false;
        }       
    }
    void Update()
    {
        if (notmoving == false)
        {
            Gear.transform.Rotate(0, 2, 0);
            Gear2.transform.Rotate(0, -2, 0);

        }
    }
}
