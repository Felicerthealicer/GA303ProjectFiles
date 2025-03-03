using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class BooList : MonoBehaviour
{

    public List<BooScript> boos = new List<BooScript>();
    public GameObject booPreFab;

    public int booCount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        booCount = Random.Range(20, 30);
        for (int i = 0; i < booCount; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-10.3f, 10.3f), 1.2f, Random.Range(-7f, 6.25f));
            GameObject boo = Instantiate(booPreFab, spawnPosition, booPreFab.transform.rotation);

            Debug.Log("There are " + booCount + " Boos");
        }

        boos = FindObjectsByType<BooScript>(FindObjectsSortMode.None).ToList();

    }

    // Update is called once per frame
    void Update()
    {
        foreach (BooScript boo in boos)
        {
            boo.RandomizedMovement();
            boo.BooDisappear();
        }
    }
}
