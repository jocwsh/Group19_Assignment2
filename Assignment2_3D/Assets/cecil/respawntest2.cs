using UnityEngine;

public class respawntest2 : MonoBehaviour
{
    public GameObject player; //player prefab goes here

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = new Vector3(0f, 2f, 0f);
            Debug.Log("AAAAAAAAAAAAA");
        }
    }
}
