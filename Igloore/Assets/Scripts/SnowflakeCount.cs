using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnowflakeCount : MonoBehaviour
{
    public int score = 0; // initial score of each stage will always be 0. ~TW
    private Text uiText;

    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = score.ToString("#,0") + "/1"; // basic UI text ~TW
    }
}
