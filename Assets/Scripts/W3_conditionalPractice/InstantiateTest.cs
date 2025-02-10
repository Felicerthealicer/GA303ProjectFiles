using UnityEngine;

public class InstantiateTest : MonoBehaviour
{

    public GameObject cannonBallPreFab;
    public GameObject cannonBallSpawnPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //instantiate veison spawns the cannonBallPreFab, at the cannonBallSpawnPosition's position with the same rotation it is in the prefab.

        GameObject go = Instantiate(cannonBallPreFab,cannonBallSpawnPosition.transform.position,cannonBallPreFab.transform.rotation);

        go.GetComponent<MeshRenderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)) //If we are holding down the space key...
        {
            Instantiate(cannonBallPreFab, cannonBallSpawnPosition.transform.position, cannonBallPreFab.transform.rotation);
        }
        
    }
}
