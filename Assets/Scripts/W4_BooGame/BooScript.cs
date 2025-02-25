using UnityEngine;
using UnityEngine.UIElements;

public class BooScript : MonoBehaviour
{

    public Rigidbody rbody;
    public Vector3 moveDirection;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Use thi for moving rigidbodies around that will care about colliders! 
        rbody.AddForce(moveDirection * speed * Time.deltaTime);

        // Don't do this for rigidbody moving around! 
        // this.transform.position += moveDirection * speed * Time.deltaTime;

        /*disappearTimer -= Time.deltaTime;
        if (disappearTimer <= 0)
        {
            BooGhost();
            disappearTimer = defaultTime;
        }*/

        

    }

    public void RandomizedMovement()
    {
        Vector3 randomDirection = Vector3.zero;

        randomDirection.x = Random.Range(-0.5f, 0.5f);
        randomDirection.z = Random.Range(-0.5f, 0.5f);

        this.gameObject.GetComponent<Rigidbody>().AddForce(randomDirection * 20f);

    }

    void ChangeDirection()
    {
        moveDirection = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
    }

    void BooGhost()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = new Color(221, 221, 221, Random.Range(0f, 135f)); 
    }

    public void BooTimer()
    {
        float disappearTimer = Random.Range(5f, 10f);

        disappearTimer -= Time.deltaTime;
        Debug.Log(disappearTimer); //why is timer not reaching 0 ?? 

        if (disappearTimer <= 0)
        {
            BooGhost();
        }
    }

}
