using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;




public class button : MonoBehaviour
{
    private float i = 0;
    public GameObject Cube;

    public void ButtonClicked()
    {
        //Object.Instantiate (Cube, new Vector3(0,2,0), Quaternion.identity);
        //spawn();


    }

    void spawn()
    {
        Object.Instantiate (Cube, new Vector3(0,i,0), Quaternion.identity);
        i =+ 1f;
    }

    
}
