using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;




public class button : MonoBehaviour
{
    public float i = 0;
    public GameObject Cube;

    public void ButtonClicked()
    {
        //Object.Instantiate (Cube, new Vector3(0,2,0), Quaternion.identity);
        Object.Instantiate(Cube, new Vector3(0, i, 0), Quaternion.identity);
        i += 1.5f;
        Debug.Log(i);


    }

    void spawn()
    {
        //Object.Instantiate (Cube, new Vector3(0,2,0), Quaternion.identity);
        
    }

    
}
