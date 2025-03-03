using UnityEngine;
using UnityEngine.UIElements;

public class BooScript : MonoBehaviour
{

    public Rigidbody rbody;
    public Vector3 moveDirection;
    public float speed;

    public MeshRenderer meshRenderer;

    public bool hasTheGhostDisappeared = true;
    public bool hasTheGhostReappeared = false;
    float disappearTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();

        disappearTimer = Random.Range(5f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        //Use this for moving rigidbodies around that will care about colliders! 
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
        // this.gameObject.GetComponent<MeshRenderer>().material.color = new Color(221, 221, 221, Random.Range(0f, 0.5f)); 
        meshRenderer.enabled = false;
    }

    public void BooDisappear()
    {

        if (hasTheGhostDisappeared == true)
        {
            if (disappearTimer > 0)
            {
                disappearTimer -= Time.deltaTime;
            }
            else if (disappearTimer <= 0)
            {
                meshRenderer.enabled = false;
                disappearTimer = Random.Range(5f, 10f);
                hasTheGhostDisappeared = false;
                hasTheGhostReappeared = true;
            }
        }

        if (hasTheGhostReappeared == true)
        {
            if (disappearTimer > 0)
            {
                disappearTimer -= Time.deltaTime;
            }
            else if (disappearTimer <= 0)
            {
                meshRenderer.enabled = true;
                disappearTimer = Random.Range(5f, 10f);
                hasTheGhostReappeared = false;
                hasTheGhostDisappeared = true;
            }
        }
    }
}
