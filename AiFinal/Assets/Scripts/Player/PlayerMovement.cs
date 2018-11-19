using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public float speed;

    Rigidbody rb;
    Animator anim;

    public float speedH = 2.0f;

    private float yaw = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");

        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");        

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddRelativeForce(movement * speed);

        Animating(moveHorizontal, moveVertical);

    }

    void Animating(float h, float v)
    {
        bool walking = h != 0f || v != 0f;
        anim.SetBool("IsWalking", walking);
    }
}
