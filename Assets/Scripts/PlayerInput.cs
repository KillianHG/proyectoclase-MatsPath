using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour { 

    public float speed = 5f;

    public PlayerSO so;

    Animator anim;
    Rigidbody2D rb;
    Vector2 mov;
    
    
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        rb.position = new Vector2(so.spawnPositionX, so.spawnPositionY); 
    }
    
    void Update()
    {
        mov = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        /*float horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0f)
        {
            transform.position = new Vector3(transform.position.x + (horizontal * speed * Time.deltaTime), transform.position.y, 0);
        }

        float vertical = Input.GetAxis("Vertical");
        if (vertical != 0f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + (vertical * speed * Time.deltaTime), 0);
        }*/
        /*Vector3 mov = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        if (mov != Vector3.zero) { 
        transform.position = Vector3.MoveTowards(transform.position, transform.position + mov, speed * Time.deltaTime);*/

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
    }

}
