using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    public GameObject cube;

   
    void Start()
    {
        
    }

    
    void Update()
    {
        //transform.position = cube.transform.position;
        transform.position = cube.transform.position + new Vector3(0, 1, -7);
    }
}
