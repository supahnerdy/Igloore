using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgorPlatform : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        col.transform.parent = this.transform;
    }

    void OnCollisionExit(Collision col)
    {
        col.transform.parent = null;
    }
}
