using UnityEngine;

public class UpdatedInstatntiate : MonoBehaviour
{

    public GameObject cannonBallPreFab;
    public GameObject cannonBallSpawnPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject go = Instantiate(cannonBallPreFab, cannonBallSpawnPosition.transform.position, cannonBallPreFab.transform.rotation);

        go.GetComponent<MeshRenderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(cannonBallPreFab, cannonBallSpawnPosition.transform.position, cannonBallPreFab.transform.rotation);
        }
    }
}
