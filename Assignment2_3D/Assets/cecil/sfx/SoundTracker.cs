using UnityEngine;
using System.Collections;

public class soundkey : MonoBehaviour { 

    public AudioSource slamkey;

        void start ()
    {

    }

        void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            slamkey.Play();
        }

    }
}
