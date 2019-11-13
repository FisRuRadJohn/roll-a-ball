using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{

    public Rigidbody myRigiBody;
    public float speed;
    public float maxspeed;
    public Text scoreText;
    

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

        if (myRigiBody.velocity.magnitude > maxspeed)

        {
            myRigiBody.velocity = myRigiBody.velocity.normalized * maxspeed;
        }

    }

    //comparamos mediante el uso de tags para identificar el objeto que recogemos, al objeto (tigger lo desactivamos y sumamos su valor)
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pt"))
        {
            other.gameObject.SetActive(false);

            score += other.gameObject.GetComponent<Pickup>().points;
            scoreText.text = "Score: " + score;
        }
      
    }



}
