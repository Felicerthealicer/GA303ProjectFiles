using UnityEngine;

public class OlliePictureScript : MonoBehaviour
{

    public StartScript buttons;
    public GameObject startButton;
    public GameObject catYes;
    public GameObject tiltingOllie;
    public GameObject upsideDownOllie;
    public GameObject redOllie;
    public GameObject stopIt;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttons.scaleIncrease = 50f;
        Debug.Log("ReferenceScript");
    }

    // Update is called once per frame
    void Update()
    {

        TiltingOllie();
        UpsideDownOllie();
        RedOllie();
        StopIt();

    }

    public void TiltingOllie()
    {
        if (catYes.transform.localScale.x > 15f)

        {
            startButton.SetActive(false);
            tiltingOllie.SetActive(true);

        }

    }

    public void UpsideDownOllie()
    {
       
        if (catYes.transform.localScale.x > 20f)
        {
            tiltingOllie.SetActive(false);
            upsideDownOllie.SetActive(true);
        }
    }

    public void RedOllie()
    {
        if (catYes.transform.localScale.x > 30f) 
        {
            upsideDownOllie.SetActive(false);
            redOllie.SetActive(true);
        }
    }

    public void StopIt()
    {
        if (catYes.transform.localScale.x>40f)
        {
            redOllie.SetActive(false);
            stopIt.SetActive(true);
            catYes.SetActive(false);

        }    
    }

}
