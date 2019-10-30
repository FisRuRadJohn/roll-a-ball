using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody myRigiBody;
    public float speed;


    int score;
   // private Vector3 ipo;

    // Start is called before the first frame update
    void Start()
    {
        // ipo = new Vector3(0,0,0);
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {  
    }

    private void FixedUpdate()
    {
        float movementHorizontal = Input.GetAxis("Horizontal");
        float movementVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movementHorizontal, 0f, movementVertical);
        myRigiBody.AddForce(movement * speed);
    }

    //comparamos mediante el uso de tags para identificar el objeto que recogemos
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pt"))
        {
            other.gameObject.SetActive(false);

            score += other.gameObject.GetComponent<Pickup>().points;
            Debug.Log("puntuacion: " + score);
        }
    }
}
