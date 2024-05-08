using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToWin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WinSceneCall());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WinSceneCall()
    {
        yield return new WaitForSeconds(11.283f);
        SceneManager.LoadScene("YouWon");
    }
}
