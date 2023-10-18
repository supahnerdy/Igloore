using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IglooUnlocked : MonoBehaviour
{
    public SnowflakeCount snowflake;
    // Start is called before the first frame update
    void Start()
    {
        // set igloo color to grey
    }

    // Update is called once per frame
    void Update()
    {
        // if score is 1/1, change to purple
    }

    void OnTriggerEnter(Collider other)
    {
        if (snowflake.score == 1)
        {
            SceneManager.LoadScene("SampleScene");
        }
        
    }
}
