using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Luigi : MonoBehaviour
{

    public GameObject luigiPreFab;

    public bool isClickingAllowed = true;

    public int numOfClicks;
    public TextMeshProUGUI clickCount;

    public GameObject background;
    public GameObject winScreen;

    public AudioSource wrongSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(430f, 545f), Random.Range(285, 365), -41f);
        GameObject luigi = Instantiate(luigiPreFab, spawnPosition, luigiPreFab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(isClickingAllowed == true)
        {
            if (Input.GetMouseButtonDown(0))
            {

                numOfClicks++;

                RaycastHit2D rayhit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));

                if (rayhit.transform != null)
                {
                    if (rayhit.collider.tag == "Luigi")
                    {
                        Debug.Log("Correct!");
                        WinScreen();
                    }
                    else
                    {
                        Debug.Log("Hits something else!");
                        wrongSound.Play();
                    }
                }
            }
        }
    }

    private void WinScreen()
    {
        background.SetActive(false);
        winScreen.SetActive(true);
        clickCount.text = "You clicked " + numOfClicks.ToString() + " times!";
        isClickingAllowed = false;
    }

}
