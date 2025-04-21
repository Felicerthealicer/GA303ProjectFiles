using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawningManager : MonoBehaviour
{
    public List<Movement> notLuigis = new List<Movement>();
    public GameObject marioPreFab;
    public GameObject yoshiPreFab;
    public GameObject toadPreFab;

    public int marioCount;
    public int yoshiCount;
    public int toadCount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // set the count to a certain number, for loop, give it a spawn position, instaniate, find by script 

        marioCount = Random.Range(15, 20);
        yoshiCount = Random.Range(15, 20);
        toadCount = Random.Range(15, 20);

        for (int i = 0; i < marioCount; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(410f, 520f), Random.Range(300, 340), -41f);
            GameObject notLuigi = Instantiate(marioPreFab, spawnPosition, yoshiPreFab.transform.rotation);
        }

        for (int i = 0; i < yoshiCount; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(430f, 545f), Random.Range(285, 365), -41f);
            GameObject notLuigi = Instantiate(yoshiPreFab, spawnPosition, yoshiPreFab.transform.rotation);

        }

        for (int i = 0; i < toadCount; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(430f, 545f), Random.Range(285, 365), -41f);
            GameObject notLuigi = Instantiate(toadPreFab, spawnPosition, toadPreFab.transform.rotation);

        }

        notLuigis = FindObjectsByType<Movement>(FindObjectsSortMode.None).ToList();
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
