using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : Singleton<GameManager>
{ 

    public TowerBtn ClickedBtn { get; private set; }

    private int currency;
    public TextMeshProUGUI currenctTxt;



    public int Currency {
        get
        {
          return  currency;
        }
        set
        {
            this.currency = value;
            this.currenctTxt.text = value.ToString();
        }
    } 

    private void Start()
    {
        currenctTxt= GameObject.Find("Canvas/Coin Text").GetComponent<TextMeshProUGUI>();
        Currency = 0;
    }

    

    public void PickTower(TowerBtn towerBtn)
    {
        if(Currency >= towerBtn.Price)
        {
            this.ClickedBtn = towerBtn;
        }
        
    }
    public void BuyTower()
    {
        ClickedBtn = null;
    }
}
