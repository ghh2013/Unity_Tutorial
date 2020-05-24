using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4 : MonoBehaviour
{
    private BoxCollider col;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        other.transform.position += new Vector3(0, 0, 0.1f);
    }

    void OnTriggerExit(Collider other)
    {
        other.transform.position = new Vector3(0, 2, 0);
    }
}
