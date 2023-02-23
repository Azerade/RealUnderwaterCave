using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
    public Transform[] _trackedWaypoints;

    public Color [] _rainbow;


    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;

        for (int i = 0; i < _trackedWaypoints.Length; i++)
        {
            Gizmos.color = _rainbow[i % _rainbow.Length];
            Gizmos.DrawSphere(_trackedWaypoints[i].position, 0.25f);
        }
    }
}
