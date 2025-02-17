using UnityEngine;

public class SpawnBall : MonoBehaviour
{

    public GameObject ballPreFab;
    public GameObject spawnPosition;
    public GameObject spawnPosition2;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BallSpawn();
    }

    void BallSpawn()
    {

        Debug.Log("Ball is Spawned");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ballPreFab, spawnPosition.transform.position, ballPreFab.transform.rotation);
            ballPreFab.GetComponent<Rigidbody>().AddForce(Vector3.down * 100f);
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            Instantiate(ballPreFab, spawnPosition2.transform.position, ballPreFab.transform.rotation);
            ballPreFab.GetComponent<Rigidbody>().AddForce(Vector3.down * 100f);
        }
    }
}

