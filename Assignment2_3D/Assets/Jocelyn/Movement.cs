using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 playerMovementInput;

    // Movement
    public Rigidbody playerBody;
    public float horizontalInput;
    public float verticalInput;
    public float moveSpeed;
    public float jumpForce;
    public bool isGround = true;

    public AudioSource audioSource;
    public AudioClip jumpSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        Cursor.visible = false;
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        movePlayer();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }

    private void movePlayer()
    {
        // Move player on x and z axis
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * moveSpeed);
        transform.Translate(-Vector3.left * Time.deltaTime * horizontalInput * moveSpeed);

        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            playerBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            audioSource.clip = jumpSound;
            audioSource.Play();
            isGround = false;
        }
    }
}