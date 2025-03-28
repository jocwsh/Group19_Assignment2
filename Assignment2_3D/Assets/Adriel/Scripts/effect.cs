using UnityEngine;

public class effect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    AudioSource allclear;
    
    void Start()
    {
        allclear = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            allclear.Play();
        }
    }
}
