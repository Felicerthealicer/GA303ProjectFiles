using UnityEngine;

public class DominoAndBall : MonoBehaviour
{
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
        if (Domino.gameObject.name == "MagentaToCyan")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 100f);
        }
    }
}
