using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 moveInput;
    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float speed = 10f;
    
    void Start()
    {
        
    }

    void Update()
    {
        Run();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }
    
    void Run()
    {
        if (moveInput.x > Mathf.Epsilon)
        {
            transform.localScale = new Vector2(1, transform.localScale.y);
        } else if (moveInput.x < -Mathf.Epsilon)
        {
            transform.localScale = new Vector2(-1, transform.localScale.y);
        }
        rbody.velocity = new Vector2(moveInput.x * speed, transform.position.y);
    }
    
}
