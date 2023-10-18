using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowflakeScript : MonoBehaviour
{
    public SnowflakeCount keepScore;

    private void OnTriggerEnter(Collider col)
    {
        GameObject collidedWith = col.gameObject;
        if (col.CompareTag("Igor"))
        {
            gameObject.SetActive(false);
            keepScore.score += 1;
        }
    }
}
