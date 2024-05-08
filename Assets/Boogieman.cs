using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boogieman : MonoBehaviour
{
    public enum BoogiemanMoveType { tf, physics };
    [SerializeField] int speed = 0;
    [SerializeField] private GameObject body;
    [SerializeField] BoogiemanMoveType movementType;
    [SerializeField] private List<AnimationStateChanger> animationStateChanger;
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

    public void moveBoogie(Vector3 direction)
    {
        if(movementType == BoogiemanMoveType.tf)
        {
            moveBoogieTransform(direction);
        }

        else if(movementType == BoogiemanMoveType.physics)
        {
            moveBoogieRB(direction);
        }

        if (direction != Vector3.zero)
        {
            foreach (AnimationStateChanger asc in animationStateChanger)
            {
                asc.ChangeAnimationState("walk", speed);
            }
        }
        else
        {
            foreach (AnimationStateChanger asc in animationStateChanger)
            {
                asc.ChangeAnimationState("idle");
            }
        }
    }
    public void moveBoogieRB(Vector3 direction)
    {
        Vector3 currentVelocity = new Vector3(0, rb.velocity.y, 0);
        rb.velocity = (currentVelocity) + (direction * speed);
        if (rb.velocity.x < 0)
        {
            body.transform.localScale = new Vector3(1, 1, 1);
        }
        else if (rb.velocity.x > 0)
        {
            body.transform.localScale = new Vector3(-1, 1, 1);
        }
        rb.velocity = direction * speed;
    }

    public void moveBoogieTransform(Vector3 direction)
    {
        transform.position += direction * Time.deltaTime;
    }

    public void Eat()
    {
        CookieCounter.thisCounter?.RegisterCookies();
        GetComponent<AudioSource>().Play();
    }
}
