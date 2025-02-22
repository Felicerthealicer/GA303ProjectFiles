using NUnit.Framework.Constraints;
using UnityEngine;

public class TimerCountingDown : MonoBehaviour
{

    public float timerCountingDown = 5f;
    public float defaultTime = 5f;
    public bool timerIsZero = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (timerIsZero == false)
        {
            timerCountingDown -= Time.deltaTime;
            Debug.Log(timerCountingDown);

            if (timerCountingDown <= 0f)
            {
                Debug.Log("Countdown ended");
                timerCountingDown = defaultTime; 
                timerIsZero = true;
            }

        }
    }

    
}
