using UnityEngine;

public class CharacterMoveScript : MonoBehaviour
{
    public GameObject Piegon;
    public GameObject Sonic;
    public Vector3 moveDirection;
    public float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterMovement(); 
    }

    public void CharacterMovement()
    {
        this.transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

}
