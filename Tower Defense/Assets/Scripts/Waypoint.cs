using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    // public ok here as is a data class
    public bool isExplored = false;
    public Waypoint exploredFrom;
    public bool isPlacable = true;

    [SerializeField] Tower towerPrefab;
    [SerializeField] Tower bigTowerPrefab;

    Vector2Int gridPos;

    const int gridSize = 10;

    public int GetGridSize()
    {
        return gridSize;
    }
	

    public Vector2Int GetGridPos()
    {
        return new Vector2Int(
            Mathf.RoundToInt(transform.position.x / gridSize),
            Mathf.RoundToInt(transform.position.z / gridSize)
        );
    }

    public void SetTopColor(Color color)
    {
        MeshRenderer topMeshRenderer = transform.Find("Top").GetComponent<MeshRenderer>();
        topMeshRenderer.material.color = color;
    }

    void OnMouseOver()
    {
        if (isPlacable)
        {
            SetTopColor(Color.green);
        }
        else
        {
            SetTopColor(Color.red);
        }

        if (Input.GetMouseButtonDown(0))
        {
            PlaceTower();
        }

            //if (Input.GetMouseButtonDown(1))
            //{
            //    if (isPlacable && EnemySpawner.coin >= 20)
            //    {
            //        //Instantiate(bigTowerPrefab, transform.position, Quaternion.identity);
            //        Instantiate(GameManager.Instance.ClickedBtn.TowerPrefab, transform.position, Quaternion.identity);
            //        GameManager.Instance.BuyTower();
            //        isPlacable = false;
            //        EnemySpawner.coin = EnemySpawner.coin - 20;
            //    }
            //    else
            //    {
            //        print("Can not place here");
            //    }

            //}

    }

    private void OnMouseExit()
    {
        if (isPlacable)
        {
            SetTopColor(Color.white);
        }
        else
        {
            SetTopColor(Color.yellow);
        }
        
    }


    private void PlaceTower()
    {

    if (isPlacable && GameManager.Instance.Currency >= 10)
    {
        //Instantiate(towerPrefab, transform.position, Quaternion.identity
        Instantiate(GameManager.Instance.ClickedBtn.TowerPrefab, transform.position, Quaternion.identity);
        GameManager.Instance.BuyTower();
        isPlacable = false;
        GameManager.Instance.Currency = GameManager.Instance.Currency - 10;
    }
    else
    {
        print("Can not place here");
    }

        
    }


}
