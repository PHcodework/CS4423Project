using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToLose : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoseSceneCall());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator LoseSceneCall()
    {
        yield return new WaitForSeconds(11.283f);
        SceneManager.LoadScene("GameOver");
    }
}
