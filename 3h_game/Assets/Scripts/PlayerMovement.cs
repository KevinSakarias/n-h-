using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    Health health; 

    void Awake()
    { 
        health = GetComponent<Health>();
    }


    void Update()
    {
        if (health.GetIsDead()) { return; }


        float moveX = Input.GetAxis("Horizontal"); 
        float moveY = Input.GetAxis("Vertical");  

        Vector2 move = new Vector2(moveX, moveY) * moveSpeed * Time.deltaTime;
        transform.Translate(move);
    }
}
