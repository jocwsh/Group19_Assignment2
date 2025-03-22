using UnityEngine;
using UnityEngine.InputSystem;

public class create_and_destroy : MonoBehaviour


{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("itworksbtw");
            Object.Instantiate(GameObject.FindGameObjectWithTag("Capsule"));
           
        }
        
    }
}
