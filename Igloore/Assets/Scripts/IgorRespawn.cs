using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgorRespawn : MonoBehaviour
{
    
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;

    // SerializeField allows me to assign in the editor ~TW

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = offset; // offset is set to spawnpoint in editor ~TW
    }
}
