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

    public float scaleIncrease;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CatButton()
    {
       
        
        if(Input.GetKeyDown(KeyCode.G))
        {

            catYes.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;

            if (catYes.transform.localScale.x > 1f)

            {
                startButton.SetActive(false);

                tiltingOllie.SetActive(true);

            }

        }

        if(Input.GetKeyDown(KeyCode.R))
        {

            catNo.transform.localScale -= Vector3.one * scaleIncrease;

            if (catNo.transform.localScale.x<1f)
            {

                blueScreen.SetActive(true);

            }
        }

        Debug.Log("Uhm");

    }


}
