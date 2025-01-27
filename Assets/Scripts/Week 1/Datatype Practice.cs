using NUnit.Framework.Constraints;
using UnityEngine;

public class DatatypePractice : MonoBehaviour
{

    int santaClaus;

    float total;
    public float mario;
    public float yoshi = 4.8f;

    char bee = 'B';

    string fullSentence;
    string intro = "Hello World!";
    string outro = "Cya Later!";

    public string chestName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        santaClaus = 56;

        santaClaus = (santaClaus + 5) * 2 / (3 - 7);

        Debug.Log(santaClaus);

        Debug.Log(yoshi);

        yoshi = yoshi - 2;

        yoshi -= 2;

        Debug.Log("Yoshi's value is " + yoshi);

        Debug.Log(bee + intro);

        total = mario + 7 + yoshi;

        Debug.Log(total);      

        fullSentence = intro + " " + outro;

        Debug.Log(fullSentence);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
