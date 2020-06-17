using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{

    [SerializeField] Waypoint startPoint;
    [SerializeField] Waypoint endPoint;

    Dictionary<Vector2Int, Waypoint> grid = new Dictionary<Vector2Int, Waypoint>();


    void Start()
    {
        LoadBlocks();
        ColorStartAndEnd();
    }

   

    void Update()
    {
        
    }

    private void LoadBlocks()
    {
        var waypoints = FindObjectsOfType<Waypoint>();
        foreach (Waypoint waypoint in waypoints)
        {
            var gridPos = waypoint.GetGridPos();
            if (grid.ContainsKey(gridPos))
            {

            }
            else
            {
                grid.Add(gridPos, waypoint);
                
            }
        }
        print(grid.Count);
    }

    private void ColorStartAndEnd()
    {
        startPoint.SetTopColor(Color.blue);
        endPoint.SetTopColor(Color.red);
    }


}
