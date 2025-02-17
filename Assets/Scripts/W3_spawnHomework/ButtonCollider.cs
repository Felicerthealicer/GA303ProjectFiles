using UnityEngine;

public class ButtonCollider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision Button)
    {
        if(Button.gameObject.tag == "ButtonTrigger")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            Button.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
}
