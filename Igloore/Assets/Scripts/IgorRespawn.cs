using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IgorRespawn : MonoBehaviour
{
    
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;

    // SerializeField allows me to assign in the editor ~TW

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Igor"))
        {
            player.transform.position = offset; // offset is set to spawnpoint in editor ~TW
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // lose snowflake upon death ~TW
        }

    }
}
