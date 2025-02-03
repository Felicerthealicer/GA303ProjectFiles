using UnityEngine;

public class beegYoshifier : MonoBehaviour
{
    public GameObject fakeBeegYoshi;
    public float scaleIncrease = .5f;
    public GameObject endScreen;

    public Vector3 rotationAmount;

    public Transform teleportTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fakeBeegYoshi.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;

        if (fakeBeegYoshi.transform.localScale.x > 65) 
        {
            endScreen.SetActive(true);
        }

    }

    public void ResetFakeBeegYoshi()
    {
        fakeBeegYoshi.transform.localScale = Vector3.one;
        scaleIncrease += .5f;
    }

    public void RotateFakeBeegYoshi()
    {
        //The following line will rotate fakeBeegYoshi by -90 degrees in the z direction by creating a new Vector3 variable to be used once at runtime.

        // fakeBeegYoshi.transform.Rotate(new Vector3(0f, 0f, -90f));

        //Alternatively, you can create a variable of type Vector3 to pass into the rotate function, like in the following line.
        //This makes it so you can change the functionally in the inspector without having to change any code.

        fakeBeegYoshi.transform.Rotate(rotationAmount);
    }
    public void TeleportBeegYoshi()
    {
        fakeBeegYoshi.transform.position = teleportTransform.position; 
    }
}
