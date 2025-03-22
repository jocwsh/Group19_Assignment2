using UnityEngine;


public class toggle : MonoBehaviour

{



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
           
        }
        
            
        

        
        
    }
}
