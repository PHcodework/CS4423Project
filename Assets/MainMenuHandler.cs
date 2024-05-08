using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
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

    public void Play()
    {
        fader.FadeToColor("MainGame");
        
    }

    public void Controls()
    {
        fader.FadeToColor("Controls");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
