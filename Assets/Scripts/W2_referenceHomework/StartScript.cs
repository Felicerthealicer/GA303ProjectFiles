using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class StartScript : MonoBehaviour
{

    public GameObject startButton;
    public GameObject tiltingOllie;
    public GameObject catYes;
    public GameObject catNo;
    public GameObject blueScreen;

    public Vector3 increaseValue;
    public Vector3 decreaseValue;

    public float scaleIncrease;
    public float scaleDecrease;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        CatButton();
    }

    public void CatButton()
    {
       
        
        if(Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("Cliking G");

            catYes.transform.localScale += increaseValue * scaleIncrease * Time.deltaTime;

        }

        if(Input.GetKeyDown(KeyCode.R))
        {

            Debug.Log("Clicking R");

            catNo.transform.localScale -= decreaseValue * scaleIncrease;

            if (catNo.transform.localScale.x<.5f)
            {

                blueScreen.SetActive(true);

            }
        }

     

    }


}
