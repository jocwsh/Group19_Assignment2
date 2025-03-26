using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;




public class button : MonoBehaviour
{
    
    public GameObject Cube;

    public void ButtonClicked()
    {

        Object.Instantiate (Cube, new Vector3(0,3,0), Quaternion.identity);
    }
}
