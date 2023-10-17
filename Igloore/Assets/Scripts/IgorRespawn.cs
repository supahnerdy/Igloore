using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgorRespawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = offset;
    }
}
