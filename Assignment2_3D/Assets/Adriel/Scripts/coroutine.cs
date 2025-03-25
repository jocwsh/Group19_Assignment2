using UnityEngine;
using System.Collections;

public class coroutine : MonoBehaviour
{
    
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
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}
