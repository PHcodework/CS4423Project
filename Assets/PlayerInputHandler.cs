using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] Boogieman playerBoogie;
    [SerializeField] float walkSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = Vector3.zero;

        //The player's walking controls
        if (Input.GetKey(KeyCode.A))
        {
            input.x -= walkSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            input.x += walkSpeed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            input.y += walkSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            input.y -= walkSpeed;
        }

        playerBoogie.moveBoogie(input);
    }
}
