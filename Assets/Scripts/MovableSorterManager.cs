using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableSorterManager : MonoBehaviour
{

    //private int sortingOrderBase = 5000;
    public float offset = 0;
    public GameObject player;
    private SpriteRenderer myRenderer;
    public int sortingLayer;

    private float timer;
    private float timerMax = 0.1f;

    void Awake()
    {
        myRenderer = player.gameObject.GetComponent<SpriteRenderer>();
    }
    
    void LateUpdate()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            timer = timerMax;
            myRenderer.sortingOrder = (int) player.transform.position.y * -100;
            sortingLayer = (int) player.transform.position.y * -100;

        }
    }
}
