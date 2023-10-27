using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timeController : MonoBehaviour
{
    // Start is called before the first frame update

    public float totalTime = 0.0f; // Set the total time in seconds.
    private float currentTime = 0.0f;
    public TextMeshProUGUI timerText; // Reference to the Text element.

    void Start()
    {
        currentTime = totalTime;
        //timerText = GameObject.Find("timerText").GetComponent<Text>();
        print(timerText.text);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime < 10.0f )
        {
            currentTime += Time.deltaTime;
            // Update the text element with the timer value.
            timerText.text = "Time: " + currentTime.ToString("F2"); // Format to two decimal places.
        }
        else
        {
            // Timer is done. Handle timer completion event here.
        }
    }
}
