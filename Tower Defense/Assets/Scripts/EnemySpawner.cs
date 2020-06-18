using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using TMPro;

public class EnemySpawner : MonoBehaviour
{
    [Range(0.1f,120f)]
    [SerializeField] float secondBetweenSpawns = 2f;
    [SerializeField] EnemyMovement enemyPrefab;



    public TextMeshProUGUI coinText;
    public static int coin;

    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        coinText = GameObject.Find("Canvas/Coin Text").GetComponent<TextMeshProUGUI>();
        StartCoroutine(RepatedlySpawnEnemies());
        coinText.text = coin.ToString();
    }
    IEnumerator RepatedlySpawnEnemies()
    {
        while (true) // forever
        {
            EnemySpawned();
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(secondBetweenSpawns);
        }
       
    }

    public void EnemySpawned()
    {
        coin = coin + 10;
        coinText.text = coin.ToString();
    }

    private void Update()
    {
        coinText.text = coin.ToString();
    }



}
