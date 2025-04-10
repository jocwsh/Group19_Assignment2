using UnityEngine;

public class Respawn : MonoBehaviour
{

    public float threshold;
    public AudioSource audioSource;
    public AudioClip deathSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

   
    void FixedUpdate()
    {
        if(transform.position.y < threshold)
        {
            transform.position = new Vector3(0f, 0f, 0f);
            audioSource.clip = deathSound;
            audioSource.Play();
        }
    }
}
