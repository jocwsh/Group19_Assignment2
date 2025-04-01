using UnityEngine;

public class Movement : MonoBehaviour
{

    private Vector3 playerMovementInput;

    //movement
    public Rigidbody playerBody;
    public float horizontalInput;
    public float verticalInput;
    public float moveSpeed;
    public float jumpForce;
    public bool isGround = true;


    void Start()
    {
       
    }

    
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        movePlayer();

    }

    private void movePlayer()
    {
        //move player on x and z axis
   
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * moveSpeed);
        transform.Translate(-Vector3.left * Time.deltaTime * horizontalInput * moveSpeed);

        //jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
