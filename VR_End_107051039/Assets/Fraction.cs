using System;
using UnityEngine;

public class Fraction : MonoBehaviour
{
    [Header("分數")]
    public int score;
    [Header("丟中分數")]
    public int scoreIn=1;

    private Light Light1;
    private Light Light2;
    private Light Light3;
    private Light LightR;
    private Light Light4;

    // Use this for initialization
    void Start()
    {
        Light1 = GameObject.Find( "燈一").GetComponent<Light>();
        Light2 = GameObject.Find("燈二").GetComponent<Light>();
        Light3 = GameObject.Find("燈三").GetComponent<Light>();
        LightR = GameObject.Find("紅燈").GetComponent<Light>();
        Light4 = GameObject.Find("燈四").GetComponent<Light>();

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Doll")
        {

            AddScore();
        }
    }

    private void AddScore()
    {
        score += scoreIn;
        print(score);
        if (score == 1)
        {
            Light1.enabled = false;

        }
        if (score == 2)
        {
            Light2.enabled = false;

        }

        if (score == 3)
        {
            Light3.enabled = false;
            LightR.enabled = false;
            Light4.enabled = false;
        }
    }
}
