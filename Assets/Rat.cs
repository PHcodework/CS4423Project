using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat : MonoBehaviour
{
    public BoogiemanHealth health;
    public Boogieman thisBoogie;
    [SerializeField] int speed = 2;
    [SerializeField] int radius = 20;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, thisBoogie.transform.position);
        Vector2 direction = thisBoogie.transform.position - transform.position;

        direction.Normalize();

        if(distance < radius)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, thisBoogie.transform.position, speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Boogieman>() != null)
        {
            health.Hurt(2);
            BoogiemanHealth.singleton?.RegisterHealth();
        }

    }
}
