using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seesaw : MonoBehaviour {

    public bool mushroom;
    public GameObject block;

    void Start()
    {
        block.SetActive(true);
    }

    private void OnTriggerEnter (Collider other)
    {
       block.SetActive(false);
        print("Triggered!");
    }

    void Update()
    {
        
    }
}
