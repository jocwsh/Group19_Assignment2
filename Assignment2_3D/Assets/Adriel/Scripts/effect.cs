using NUnit.Framework;
using UnityEngine;

public class effect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    AudioSource allclear;
    private bool isplaying = false;

    void Start()
    {
        allclear = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            allclear.Play();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            isplaying = !isplaying;
            if (isplaying == true)
            {
                allclear.loop = true;
                allclear.Play();
            }
            else
            {
            allclear.Stop();
            }
        
        }
        
        
    }
}
