using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor2 : MonoBehaviour
{

    public GameObject cave2;
    // int tries = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            other.gameObject.transform.position = cave2.transform.position;

        }

    }
}

