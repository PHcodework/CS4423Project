using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    [SerializeField] private Screenfader fader;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 2)
        {
            fader.FadeToColor("Losecutscene");
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        if(seconds < 10 && seconds >= 1)
        {
            timerText.text = (minutes.ToString() + ":0" + seconds.ToString());
        }
        else if (seconds < 1)
        {
            timerText.text = ("0:00");
        }
        else
        {
            timerText.text = (minutes.ToString() + ":" + seconds.ToString());
        }
    }
}
