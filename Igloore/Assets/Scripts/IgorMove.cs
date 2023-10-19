using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    // basic values to control transformation speeds. ~TW
    public float moveSpeed = 2f;
    public float rotationSpeed = 200f;
    public float jumpHeight = 5f;
    public bool onGround = true; // Igor can only jump once, from the ground ~TW

    // to assist with Igor's idle/walking animations. ~TW
    private Animator animate; 
    public AnimationClip walk;

    // using RB movements (not character controller) ~TW
    private float goMove;
    private float goTurn;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        animate = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // CHARACTER MOVEMENT:

        // Get input from the keyboard. ~TW
        goTurn = Input.GetAxis("Horizontal");
        goMove = Input.GetAxis("Vertical");

        // Move Igor forwards/backwards. ~TW
        Vector3 movement = Vector3.forward * moveSpeed * Time.deltaTime * goMove;
        transform.Translate(movement);

        // Allow Igor to turn. ~TW
        Vector3 turning = Vector3.up * rotationSpeed * Time.deltaTime * goTurn;
        transform.Rotate(turning);

        // Allow Igor to jump. ~TW
        if (Input.GetKeyDown(KeyCode.Space) && onGround == true)
        {
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            onGround = false;
        }

        // Configure Igor's animations. ~TW
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            animate.SetBool("isMoving", true);
        } else
        {
            animate.SetBool("isMoving", false);
        }
    }

    // need this to help prevent Igor from spamming jump. ~TW
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
    
}
