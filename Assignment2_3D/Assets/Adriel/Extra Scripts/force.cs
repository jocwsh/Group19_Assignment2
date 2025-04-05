using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class force : MonoBehaviour
{
    public float speed = 0;
    private float movementX;
    private float movementY;
    private Rigidbody rb;
    public float jumpforce = 1000f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        
        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);   
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0f, jumpforce));
        }

        if (Input.GetButtonDown("Restart"))
        {
            rb.position = new Vector3 (0,0.5f,0);
        }
    }


}

