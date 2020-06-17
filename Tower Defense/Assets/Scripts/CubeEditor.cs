﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
[RequireComponent (typeof(Waypoint))]
public class CubeEditor : MonoBehaviour
{

    public Waypoint waypoint;

    private void Awake()
    {
        waypoint = GetComponent<Waypoint>();   
    }

    void Update()
    {
        SnapToGrid();
        UpdateLabel();


    }

    private void SnapToGrid()
    {
        int gridSize = waypoint.GetGridSize();
        transform.position = new Vector3(
            waypoint.GetGridPos().x,
            0f,
            waypoint.GetGridPos().y
            );

    }

    private void UpdateLabel()
    {
        int gridSize = waypoint.GetGridSize();

        TextMesh textMesh = GetComponentInChildren<TextMesh>();

        string labelText =
            waypoint.GetGridPos().x/10 +
            "," +
            waypoint.GetGridPos().y/10 ;

        textMesh.text = labelText;
        gameObject.name = labelText;
    }
}