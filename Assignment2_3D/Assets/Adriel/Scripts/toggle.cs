using UnityEngine;


public class toggle : MonoBehaviour
{
public GameObject sphere;
private bool toggleison = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) & toggleison == true)
        {
            
            sphere.SetActive(false);
            toggleison = false;
            Debug.Log(toggleison);
        }
            
        else if (Input.GetKey(KeyCode.Mouse0) & toggleison == false)
        {
            sphere.SetActive(true);
            toggleison = true;
            Debug.Log(toggleison);
        }
            
        

        
        
    }
}
