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


    void Start()
    {
       
    }

    
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        //playerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        movePlayer();

    }

    private void movePlayer()
    {
        //move player on x and z axis
        //Vector3 MoveVector = transform.TransformDirection(playerMovementInput) * moveSpeed;
        //playerBody.velocity = new Vector3(MoveVector.x, playerBody.velocity.y, MoveVector.z);
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * moveSpeed);
        transform.Translate(-Vector3.left * Time.deltaTime * horizontalInput * moveSpeed);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
