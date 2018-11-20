using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public float speed;

    Rigidbody rb;
    Animator anim;

    public float speedH = 2.0f;
    public float speedV = 2.0f;
    public bool inverse = false;

    public int minRotation = -20;
    public int maxRotation = 20;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        if (inverse)
        {
            pitch +=  speedV * Input.GetAxis("Mouse Y");
        }
        else
        {
            pitch += -1 * speedV * Input.GetAxis("Mouse Y");
        }

        //Debug.Log(pitch);
        if (pitch >= -1 * maxRotation && pitch <= minRotation)
        {
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }

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
