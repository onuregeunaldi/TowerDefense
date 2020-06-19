using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerBtn : MonoBehaviour
{

    [SerializeField]private GameObject towerPrefab;
    [SerializeField]private int price;
    [SerializeField]private Text priceTxt;


    public GameObject TowerPrefab { get => towerPrefab;}
    public int Price { get => price;}

    private void Start()
    {
        priceTxt.text = Price.ToString();
    }
}
