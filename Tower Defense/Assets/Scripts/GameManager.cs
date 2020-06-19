using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{ 

    public TowerBtn ClickedBtn { get; private set; }

    public void PickTower(TowerBtn towerBtn)
    {
        this.ClickedBtn = towerBtn;
    }
    public void BuyTower()
    {
        ClickedBtn = null;
    }
}
