using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConfiner : MonoBehaviour
{
    public void ChangeConfiner(PolygonCollider2D newConfiner)
    {
        gameObject.GetComponent<Cinemachine.CinemachineConfiner>().m_BoundingShape2D = newConfiner;
    }
}
