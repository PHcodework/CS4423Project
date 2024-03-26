using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CookieCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinNumber;

    public static CookieCounter thisCounter;

    int cookiesEaten = 0;

    void Awake()
    {
        if(thisCounter != null)
        {
            Destroy(this.gameObject);
        }
        thisCounter = this;
    }
    void Start()
    {
        coinNumber.text = cookiesEaten.ToString();
    }

    public void RegisterCookies()
    {
        cookiesEaten += 1;
        coinNumber.text = cookiesEaten.ToString();
        if(cookiesEaten == 20)
        {
            SceneManager.LoadScene("YouWon");
        }
    }
}
