using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpManager : MonoBehaviour {

	public GameObject warps;
	public PlayerSO so;

	public GameObject player;
	public GameObject startWarp;

	CameraConfiner cam;

	void Start () {
		cam = FindObjectOfType<Cinemachine.CinemachineVirtualCamera>().GetComponent<CameraConfiner>();
		Transform parent = warps.transform;
		
        for (int i = 0; i < parent.childCount; i++)
        {
			GameObject child = parent.GetChild(i).gameObject;
			print(child.GetComponent<Warp>().uniqueID);
            if (so.spawnWarp.Equals(child.GetComponent<Warp>().uniqueID))
            {
                startWarp = child;
				player.GetComponent<Rigidbody2D>().position = startWarp.transform.GetChild(0).transform.position;
				PolygonCollider2D targetConfiner = startWarp.GetComponent<Warp>().currentMap.GetComponentInChildren<PolygonCollider2D>();
				cam.ChangeConfiner(targetConfiner);
            }
        }
		print(startWarp.transform.GetChild(0).transform.position);

		//player.GetComponent<Rigidbody2D>().position = startWarp.transform.GetChild(0).transform.position;

		print(player.GetComponent<Rigidbody2D>().position);
	}
	
	void Update () {
		
	}
}
