using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    //Both these force stats can be edited within unity
    public float forwardForce = 2000f; //applies a forward force of 2000 to the player
    public float sidewaysForce = 500f; //applies a sideways force of 500 and -500 to the player

    // Fixed Update is called once per frame, and allows collisions to work better than with Update()
    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d")) //If the player is pressing the d key
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) //If the player is pressing the a key
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().gameOver();
        }
    }
}
