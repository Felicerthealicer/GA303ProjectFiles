using UnityEngine;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour
{

    float randomXDirection;
    float randomYDirection;
    public Vector3 moveDirection;

    float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        speed = 5f;

        randomXDirection = Random.Range(-10, 10f);
        randomYDirection = Random.Range(-10f, 10f);

        moveDirection = new Vector3(randomXDirection, randomYDirection, 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += moveDirection * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Vertical")
        {
            moveDirection.x *= -1;
            // Debug.Log(other.gameObject);
        }
        else if (other.gameObject.tag == "Horizontal")
        {
            moveDirection.y *= -1;
            // Debug.Log(other.gameObject);
        }
    }

}
