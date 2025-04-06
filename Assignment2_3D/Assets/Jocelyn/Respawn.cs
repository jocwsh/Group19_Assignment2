using UnityEngine;

public class Respawn : MonoBehaviour
{

    public float threshold;

    void Start()
    {
        
    }

   
    void FixedUpdate()
    {
        if(transform.position.y < threshold)
        {
            transform.position = new Vector3(0f, 0f, 0f);
        }
    }
}
