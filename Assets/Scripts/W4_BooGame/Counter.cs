using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{

    public TextMeshProUGUI counterText;
    public int counter = 0;

    public bool allowCounting = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(allowCounting == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                CountUp();
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                CountDown();
            }
        }

    }

    void CountUp()
    {
        counter++;
        UpdateCounterUI();
    }

    void CountDown()
    {
        /*
        counter--;

        if (counter < 0)
        {
            counter = 0;
        }*/

        if(counter > 0) //simplified
        {
            counter--;
        }
        
        UpdateCounterUI();
    }

    void UpdateCounterUI()
    {
        counterText.text = counter.ToString();
    }

}
