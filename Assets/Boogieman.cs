using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boogieman : MonoBehaviour
{
    [SerializeField] int speed = 0;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveBoogieRB(Vector3 direction)
    {
        rb.velocity = direction * speed;
    }

    public void moveBoogie(Vector3 direction)
    {
        transform.position += direction * Time.deltaTime;
    }

    public void Eat()
    {
        CookieCounter.thisCounter?.RegisterCookies();
        GetComponent<AudioSource>().Play();
    }
}
