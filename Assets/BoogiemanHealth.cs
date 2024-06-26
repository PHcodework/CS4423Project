using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class BoogiemanHealth : MonoBehaviour
{
    [SerializeField] private Screenfader fader;

    public int fullHealth = 10;
    public int health;

    public static BoogiemanHealth singleton;
    [SerializeField] private TextMeshProUGUI healthText;

    // Start is called before the first frame update
    void Start()
    {
        singleton = this;
        health = fullHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hurt(int damage)
    {
        health -= damage;
        GetComponent<AudioSource>().Play();
        if (health <= 0)
        {
            fader.FadeToColor("Losecutscene");
        }
    }

    public void RegisterHealth()
    {
        healthText.text = health.ToString();
    }
}
