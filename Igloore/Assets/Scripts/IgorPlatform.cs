using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgorPlatform : MonoBehaviour
{
    public GameObject player;

    // so Igor can stick on moving platforms, need to temp set parent. ~TW
    void OnCollisionEnter(Collision col)
    {
        col.transform.parent = this.transform;
    }

    // remove parent property when stepping off platform. ~TW
    void OnCollisionExit(Collision col)
    {
        col.transform.parent = null;
    }
}
