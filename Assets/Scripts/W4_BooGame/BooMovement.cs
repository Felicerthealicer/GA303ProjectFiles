using UnityEngine;

public class BooMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomizedMovement()
    {
        Vector3 randomDirection = Vector3.zero;

        randomDirection.x = Random.Range(-1f, 1f);
        randomDirection.y = Random.Range(-1, 1f);
        randomDirection.z = Random.Range(-1, 1f);

        this.gameObject.GetComponent<Rigidbody>().AddForce(randomDirection * 100f);

    }

}
