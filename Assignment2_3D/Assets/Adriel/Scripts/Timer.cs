using UnityEngine;

public class Timer : MonoBehaviour


{
    private float countdown = 2.0f;


    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0.0f)
        {
            countdownend();
        }
    }

    void countdownend()
    {
        Destroy(GameObject.FindGameObjectWithTag("Cube"));
    }
}


