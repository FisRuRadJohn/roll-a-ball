using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anuncement : MonoBehaviour
{

    public GameObject cartel;


    // Start is called before the first frame update
    void Start()
    {
        cartel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            cartel.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            cartel.gameObject.SetActive(false);
        }
    }
}