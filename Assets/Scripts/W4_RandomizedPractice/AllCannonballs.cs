using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListTest : MonoBehaviour
{

    public List<CannonballScript> cannonballs = new List<CannonballScript>();
    public GameObject cannonballPreFab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        cannonballs = FindObjectsByType<CannonballScript>(FindObjectsSortMode.None).ToList();
        //Finds all objects in the same scene that has the Cannonball script on it and turns it into a list to be used by the cannonballs variable
        //It becomes a list of cannonball scripts.

        //GameObject.FindGameObjectsWithTag("Cannonball").ToList();
        //Finds all GameObjects in the scene with the specified tag.
        //Returns it as an array of GameObjects that you can convert to a List.

        GameObject go = Instantiate(cannonballPreFab);
        cannonballs.Add(go.GetComponent<CannonballScript>());
        //You can add an object directly to a list by calling the list variable's name.Add();
        //It must be the same type as the list.
        //If you have a list of GameObjects, make sure you give it a GameObject. 
        //In this case, we have a Cannonball script that we want to add to the list of Cannonball scripts.

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            foreach(CannonballScript ball in cannonballs)
            {
                ball.AddRandomForce();
            }
            //A foreach loop will go through each object in a List and allow you to do the same action for every instance in that list.
        }

        if(Input.GetKeyDown(KeyCode.G))
        {

            int randomBall = Random.Range(0, cannonballs.Count);
            
            //cannonBalls.Count -1 is the actual reference to the last element.
            cannonballs[randomBall].AddRandomForce();
        }
    }
}
