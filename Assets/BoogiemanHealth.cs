using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class BoogiemanHealth : MonoBehaviour
{
    public int fullHealth = 10;
    public int health;

    public static BoogiemanHealth singleton;
    [SerializeField] private TextMeshProUGUI healthText;

    // Start is called before the first frame update
    void Start()
    {
        singleton = this;
        health = fullHealth;
        healthText.text = health.ToString();
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
            SceneManager.LoadScene("GameOver");
        }
    }

    public void RegisterHealth()
    {
        healthText.text = health.ToString();
    }
}
