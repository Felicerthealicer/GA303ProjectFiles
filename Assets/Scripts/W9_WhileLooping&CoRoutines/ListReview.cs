using System.Collections.Generic;
using UnityEngine;

public class ListReview : MonoBehaviour
{

    public List<GameObject> cubes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubes[0].SetActive(false); //first cube in the list

        cubes[cubes.Count - 1].SetActive(false); //last cube in the list 

        foreach (GameObject c in cubes) //this iterates through all objects in the list called "cubes" 
                                        //in this foreach loop, the individual element will be referenced as 'c'
        {
            Debug.Log(c.name); //displays the name of each cube in the list 
        }

        for(int i = 0; i < cubes.Count; i++)
        {
            if(i % 2 == 0) //if I divided by 2 and it has a remainder of 0...this means it is even 
            {
                Debug.Log(cubes[i].name + " is an even element!");
            }
        }    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
