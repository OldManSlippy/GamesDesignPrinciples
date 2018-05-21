using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioGrow : MonoBehaviour
{

    public bool mushon;
    public GameObject mushroom;
    public GameObject Mario;
    void Start()
    {
        mushroom.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        mushroom.SetActive(false);
        Mario.transform.localScale += new Vector3(50, 50, 50);
    }

    void Update()
    {

    }
}
