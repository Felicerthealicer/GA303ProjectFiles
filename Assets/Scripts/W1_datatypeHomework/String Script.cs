using UnityEngine;

public class StringScript : MonoBehaviour
{

    public string positiveAdjective;

    public string negativeAdjective;

    public string noun;

    string oxymoron;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        oxymoron  = positiveAdjective + " " + negativeAdjective;

        Debug.Log("this " + noun + " is " + oxymoron);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
