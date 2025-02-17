using UnityEngine;

public class ActionBall : MonoBehaviour
{
    public Vector3 moveRight;
    public Vector3 moveBack;
    public Vector3 moveLeft;
    public Vector3 moveForward;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(other.gameObject.name);

        if (other.gameObject.name == "BallTrigger1")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            this.gameObject.GetComponent<Rigidbody>().AddForce(moveRight * 100f);
        }
        else if (other.gameObject.name == "BallTrigger2")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
            this.gameObject.GetComponent<Rigidbody>().AddForce(moveBack * 100f);
        }
        else if (other.gameObject.name == "BallTrigger3")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
            this.gameObject.GetComponent<Rigidbody>().AddForce(moveLeft * 100f);
        }
        else if (other.gameObject.name == "BallTrigger4")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            this.gameObject.GetComponent<Rigidbody>().AddForce(moveForward * 100f);
        }
    }
}
