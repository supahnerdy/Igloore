using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float rotationSpeed = 200f;
    public float jumpHeight = 5f;
    public bool onGround = true;

    public Animator animate;

    private float goMove;
    private float goTurn;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // CHARACTER MOVEMENT:

        // Get input from the keyboard
        goTurn = Input.GetAxis("Horizontal");
        goMove = Input.GetAxis("Vertical");

        // Move Igor forwards/backwards
        Vector3 movement = Vector3.forward * moveSpeed * Time.deltaTime * goMove;
        transform.Translate(movement);

        // Allow Igor to turn
        Vector3 turning = Vector3.up * rotationSpeed * Time.deltaTime * goTurn;
        transform.Rotate(turning);

        // Allow Igor to jump
        if (Input.GetKeyDown(KeyCode.Space) && onGround == true)
        {
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            onGround = false;
        }

        // Configure Igor's animations
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            animate.Play("Igor Walk");
        } else
        {
            animate.Play("Igor Idle");
        }
    }

    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
    
}
