using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public SnowflakeCount snowflake; // access the snowflake score. ~TW

    void OnTriggerEnter(Collider other)
    {
        // if score = 1 when touching goal, can proceeed to next stage. ~TW
        if (snowflake.score == 1)
        {
            SceneManager.LoadScene("GameOver");
            Time.timeScale = 0f;
        }

    }
}
