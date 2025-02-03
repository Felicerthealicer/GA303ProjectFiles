using UnityEngine;

public class scriptReferencePractice : MonoBehaviour
{
    public beegYoshifier yoshiController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        yoshiController.scaleIncrease = 5f;
        yoshiController.RotateFakeBeegYoshi();
        yoshiController.RotateFakeBeegYoshi();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
