using System.Xml.Schema;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    int red = 78;

    int blue = 12;

    int green =55;

    int total;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        red = red * blue / (green - blue);
        
        blue -= green;
        
        green = blue + (green - blue) * red;

        total = red + blue + green;

        Debug.Log("the integar script total is " + total);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
