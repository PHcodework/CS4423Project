using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenuHandler : MonoBehaviour
{
    [SerializeField] private Screenfader fader;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Back2StartScreen()
    {
        fader.FadeToColor("StartScreen");
    }

    public void Back2Play()
    {
        fader.FadeToColor("MainGame");
    }
}
