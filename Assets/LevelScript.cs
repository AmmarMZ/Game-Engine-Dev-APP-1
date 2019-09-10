using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScript : MonoBehaviour
{
    Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        levelText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = "Level " + (TargetScript.totalShots - 1) + "/10";
        if (TargetScript.totalShots == 11) {
                levelText.gameObject.SetActive(false);
            }   
    }
}
