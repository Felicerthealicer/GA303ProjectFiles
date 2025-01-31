using UnityEngine;

public class FloatScript : MonoBehaviour
{

    public float cyan;

    public float yellow;

    public float magenta;

    float total;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        cyan = magenta + yellow * (cyan - yellow);

        yellow = cyan + magenta - 7;

        magenta = yellow / (magenta - cyan);

        total = cyan + yellow + magenta;

        Debug.Log("the float script total is " + total);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
