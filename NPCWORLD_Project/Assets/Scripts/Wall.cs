using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float length = 1f;
    public float height = 1f;

    public Vector3 Position => transform.position;

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(Position, new Vector3(length,height,1));
    }
}
