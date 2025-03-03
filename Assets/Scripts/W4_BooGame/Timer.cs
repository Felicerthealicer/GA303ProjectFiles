using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timerCountingDown = 30f;
    public TextMeshProUGUI timerText;
    public bool hasTimerFinished = false;
    
    public Counter counterScript;
    public BooList listScript;

    public GameObject victoryScreen;
    public GameObject loseScreen;
    public TextMeshProUGUI correctBooText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasTimerFinished == false)
        {
            if (timerCountingDown > 0)
            {
                timerCountingDown -= Time.deltaTime;
            }
            else
            {
                hasTimerFinished = true;
                counterScript.allowCounting = false;
                timerCountingDown = 0;
                EndScreen();
                Debug.Log("End");
            }

            // timerText.text = timerCountingDown.ToString("F0");
            timerText.text = Mathf.Ceil(timerCountingDown).ToString("F0"); //Mathf.Ceil rounds the number up
        }
    }

    public void EndScreen()
    {
        if (counterScript.counter == listScript.booCount)
        {
            victoryScreen.SetActive(true);
        }
        else
        {
            loseScreen.SetActive(true);
            correctBooText.text = "There were actually " + listScript.booCount.ToString() + " Boos.";
        }
    }

}
