using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgorFell : MonoBehaviour
{

    public static float border = 0f;
    [SerializeField] private Vector3 spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < border)
        {
            transform.position = spawnPoint;
        }
        
    }
}
