using UnityEngine;

public class Movement : MonoBehaviour
{

    private Vector3 playerMovementInput;

    //movement
    public Rigidbody playerBody;
    public float moveSpeed;
    public float jumpForce;


    void Start()
    {
       
    }

    
    void Update()
    {


        playerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        movePlayer();

    }

    private void movePlayer()
    {
        //move player on x and z axis
        Vector3 MoveVector = transform.TransformDirection(playerMovementInput) * moveSpeed;
        playerBody.linearVelocity = new Vector3(MoveVector.x, playerBody.linearVelocity.y, MoveVector.z);



        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerBody.linearVelocity = new Vector3(playerBody.linearVelocity.x, jumpForce, playerBody.linearVelocity.z);
        }
    }
}
