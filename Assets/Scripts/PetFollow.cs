using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetFollow : MonoBehaviour {

    public float speed;
    public Animator animator;

    //A quien sigo
    private Transform target;

	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Vector2.Distance(transform.position, target.position)>2) {
            animator.SetFloat("Speed", 1f);
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else
        {
            animator.SetFloat("Speed", 0f);
        }

        

	}
}
