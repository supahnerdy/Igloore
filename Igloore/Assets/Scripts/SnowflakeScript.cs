using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowflakeScript : MonoBehaviour
{
    public SnowflakeCount keepScore; // to access the snowflake count. ~TW

    private void OnTriggerEnter(Collider col)
    {
        GameObject collidedWith = col.gameObject;
        if (col.CompareTag("Igor")) // should check incase snowflake goes through not Igor. ~TW
        {
            gameObject.SetActive(false); // Igor collects the snowflake (disappears). ~TW
            keepScore.score += 1; // increment +1 to the UI score. ~TW
        }
    }
}
