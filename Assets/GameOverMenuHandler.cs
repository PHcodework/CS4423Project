using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenuHandler : MonoBehaviour
{
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
        SceneManager.LoadScene("StartScreen");
    }

    public void Back2Play()
    {
        SceneManager.LoadScene("MainGame");
    }
}
