using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Warp : MonoBehaviour
{

    public string uniqueID;
    public GameObject target;
    public GameObject targetMap;
    public GameObject currentMap;

    public bool active = false;

    PolygonCollider2D targetConfiner;
    CameraConfiner cam;

    public float fadeTime = 1f;
    bool start = false;
    bool isFadeIn = false;
    float alpha = 0f;

    private void Awake()
    {
        Assert.IsNotNull(target);
        Assert.IsNotNull(targetMap);
        
        cam = FindObjectOfType<Cinemachine.CinemachineVirtualCamera>().GetComponent<CameraConfiner>();
        targetConfiner = targetMap.GetComponentInChildren<PolygonCollider2D>();

    }

    IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Animator>().enabled = false;
            collision.GetComponent<PlayerInput>().enabled = false;
            FadeIn();
            yield return new WaitForSeconds(fadeTime);

            collision.transform.position = target.transform.GetChild(0).transform.position;
            cam.ChangeConfiner(targetConfiner);
            FadeOut();
            collision.GetComponent<Animator>().enabled = true;
            collision.GetComponent<PlayerInput>().enabled = true;
        }
    }

    private void OnGUI()
    {
        if (!start)
        {
            return;
        }

        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        Texture2D tex;
        tex = new Texture2D(1, 1);
        tex.SetPixel(0, 0, Color.black);
        tex.Apply ();

        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), tex);

        if (isFadeIn)
        {
            alpha = Mathf.Lerp(alpha, 1.1f, fadeTime * Time.deltaTime);
        } else
        {
            alpha = Mathf.Lerp(alpha, -0.1f, fadeTime * Time.deltaTime);
            if (alpha < 0)
            {
                start = false;
            }
        }
    }

    void FadeIn()
    {
        start = true;
        isFadeIn = true;
    }

    void FadeOut()
    {
        isFadeIn = false;
    }
}
