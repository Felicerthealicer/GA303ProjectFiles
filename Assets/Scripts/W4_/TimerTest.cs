using UnityEngine;

public class TimerTest : MonoBehaviour
{

    public float timerCountingUp = 0f;
    public float timerMaxDuration = 3f;

    public bool hasFinishedTimer = false;

    public GameObject cube;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // When using Random.Range, if you put f after the numebers in the function, it will return a decimal between those two numbers.
        // If you do NOT put an f after the number, it will return a whole number, from the first number to the last, not including the last number.
        // Example: Random.Range(1, 4) will return 1,2, or 3, but not 4.
        // If you do Random.Range(1f, 4f), it will return anywhere between 1 and 4, including decimal places, like 1.759.
        timerMaxDuration = Random.Range(1, 5);

        Invoke("MoveCubeRight", timerMaxDuration);

    }

    /*
    void Update()
    {

        //in this update, once this timer finishes, it changes a bool called hasFinishedTimer to true, which prevents additional logic from being run for the timer.
        // This is how you can make sure somthing ONLY happens ONCE based on a timer.

        if(hasFinishedTimer == false)
        {
            timerCountingUp += Time.deltaTime;
            // Debug.Log(timerCountingUp);

            if (timerCountingUp >= timerMaxDuration)
            {
                hasFinishedTimer = true;
                Debug.Log("Reached End of Timer!");
            }
        }

    }*/

    /*
    void Update()
    {
       
        //In this update, the timer counts up, but when it finally reaches the timerMaxDuration it will only move the cube to the right WITHOUT Time.deltaTime
        //We only want it to move in one motion, not over time.
        //Additionally, we reset the timeCountingUp to 0 so that it will count back up to 3 again and move the cube once more.

        timerCountingUp += Time.deltaTime;
        // Debug.Log(timerCountingUp);

        if (timerCountingUp >= timerMaxDuration)
        {
            hasFinishedTimer = true;
            Debug.Log("Reached End of Timer!");
            MoveCubeRight();
            timerCountingUp = 0f;
        }

    }*/

    void MoveCubeRight()
    {
        
        //recursively calling a function (calling the function within the function)
        
        cube.transform.position += Vector3.right;

        if(cube.transform.position.x < 10)
        {
            Invoke("MoveCubeRight", timerMaxDuration);
        }

    }

}
