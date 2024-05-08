using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacuum : MonoBehaviour
{
    public BoogiemanHealth health;
    public Boogieman thisBoogie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Boogieman>() != null)
        {
            health.Hurt(10);
            BoogiemanHealth.singleton?.RegisterHealth();
        }

    }
}
