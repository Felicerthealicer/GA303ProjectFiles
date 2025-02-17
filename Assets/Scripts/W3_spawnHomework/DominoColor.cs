using UnityEngine;

public class Colllision : MonoBehaviour
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
        Debug.Log(Domino.gameObject.tag);

        if (Domino.gameObject.tag == "MagentaDomino")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
        }
        else if (Domino.gameObject.tag == "CyanDomino")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
        }
        else if (Domino.gameObject.tag == "WhiteDomino")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }

    

}
