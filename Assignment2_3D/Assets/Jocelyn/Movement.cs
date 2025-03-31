using UnityEngine;

public class Movement : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float turnSpeed = 10;

    void Start()
    {
       
    }

    
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput);
        transform.Translate(-Vector3.right * Time.deltaTime * horizontalInput);
        //transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);

    }
}
