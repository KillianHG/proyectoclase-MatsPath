using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour { 

    public float speed = 5f;

    public PlayerSO so;

    Animator anim;
    Rigidbody2D rb;
    Vector2 mov;

    CircleCollider2D interactCollider;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        rb.position = new Vector2(so.spawnPositionX, so.spawnPositionY);

        interactCollider = transform.GetChild(0).GetComponent<CircleCollider2D>();
    }
    
    void Update()
    {
        float movX = 0;
        float movY = 0;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movY += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movY += -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movX += 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movX += -1;
        }

        mov = new Vector2(movX, movY);
        //mov = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (Input.GetKeyDown("z"))
        {
            so.spawnPositionX = rb.position.x;
            so.spawnPositionY = rb.position.y;
            print("Se ha guardado la posicion de respawn con exito, aunque esto es un ejemplo triste xD");
        }

        rb.MovePosition(rb.position + mov * speed * Time.deltaTime);
        if (mov != Vector2.zero)
        {
            anim.SetFloat("movX", mov.x);
            anim.SetFloat("movY", mov.y);
            anim.SetBool("walking", true);
        } else
        {
            anim.SetBool("walking", false);
        }

        if (mov != Vector2.zero)
        {
            interactCollider.offset = new Vector2(mov.x / 2, mov.y / 2);
        }
    }

}
