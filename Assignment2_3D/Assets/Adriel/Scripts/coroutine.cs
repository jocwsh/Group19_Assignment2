using UnityEngine;
using System.Collections;

public class coroutine : MonoBehaviour
{
    public GameObject Cube;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator wait()
    {
        Debug.Log("test01");
        yield return new WaitForSeconds(2);
        Debug.Log("it works");
        Destroy(GameObject.FindGameObjectWithTag("Cube"));
    }
}
