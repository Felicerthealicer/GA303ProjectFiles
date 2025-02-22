using UnityEngine;

public class MoveObjectsWithDirections : MonoBehaviour
{

    public GameObject point1;
    public GameObject point2;

    public float speed = 4f;

    public bool hasReachedDestination = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    /*
    void Update()
    {
        
        //This gets the direction every grame, updating when point 1 moves.
        //This causes the point1 object to steadily creep towards point 2, slowing down as it approaches because the direction is slowly getting smaller.

        Vector3 direction;
        direction = point2.transform.position - point1.transform.position;
        Debug.Log(direction);
        point1.transform.position += direction * Time.deltaTime;

    }*/

    /*
    private void Update()
    {
        
        //This verison normalizes the direction of the movement vector, so it travels steadily towards point2, multipled by a speed variable so it can speed up.
        //Unfortunately, it jitters as it reaches the end because it always moves poast the exact location of point2, so it goes back and forth until it tries to reach the exact point.
        
        Vector3 direction;
        direction = point2.transform.position - point1.transform.position;
        direction = direction.normalized;
        Debug.Log(direction);
        point1.transform.position += direction * speed * Time.deltaTime;

    }*/

    /*
    private void Update()
    {
       
        //In this verison of update, we check the distance between point 1 and point 2.
        //If it is close enough (within .1 unit), it teleports point 1 onto point 2, which is visually not noticable.
        //And it will stop trying to move point1 towards point2 because it is already on top of it and therefore within distance.
        //However, it still is teleporting it every single frame, but I don't want it to run this logic anymore once it reaches the proper location.
        // Check the next one out!

        Vector3 direction;
        direction = point2.transform.position - point1.transform.position;
        direction = direction.normalized;

        Debug.Log(Vector3.Distance(point1.transform.position, point2.transform.position));
        if(Vector3.Distance(point1.transform.position, point2.transform.position) < .1f)
        {
            point1.transform.position = point2.transform.position;
        }
        else
        {
            point1.transform.position += direction * speed * Time.deltaTime;
        }
      
    }*/

    private void Update()
    {
        
        //This verison of Update will only run if point1 hasn't reached its destination.
        //Now, it will stop running all code in Update once it has reached its destination because we have this hadReachedDestination bool variable that checks if it hasn't.
        //However, once it does reach it, we set that bool to true, preventing it from running any code in update anymore.

        if (hasReachedDestination == false) //a way to optimize this entire function, so it does not update everything every frame all the time.
        {
            Vector3 direction;
            direction = point2.transform.position - point1.transform.position;
            direction = direction.normalized;

            Debug.Log(Vector3.Distance(point1.transform.position, point2.transform.position));
            if (Vector3.Distance(point1.transform.position, point2.transform.position) < .1f)
            {
                point1.transform.position = point2.transform.position;
                hasReachedDestination = true;
            }
            else
            {
                point1.transform.position += direction * speed * Time.deltaTime;
            }
        }

    }

}
