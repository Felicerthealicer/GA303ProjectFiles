using UnityEngine;

public class Ball_AddForceMovement : MonoBehaviour
{

    public Vector3 direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision Domino)
    {

        if (Domino.gameObject.tag == "MagentaDomino")
        {
            Debug.Log("Collied");
            this.gameObject.GetComponent<Rigidbody>().AddForce(direction * 10f);
        }
        

    }
}
