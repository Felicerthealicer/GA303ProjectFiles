using UnityEngine;

public class ButtonCollider : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject endscreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (button1.GetComponent<MeshRenderer>().material.color == Color.green && button2.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            endscreen.SetActive(true);
        }
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
