using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour

{

    public GameObject player;

    public void Respawning()
    {
        player.transform.position = new Vector3(0, 2.07, 0);
    }


}