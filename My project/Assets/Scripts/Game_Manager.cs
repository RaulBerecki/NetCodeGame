using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game_Manager : MonoBehaviour
{
    //Tiles
    [SerializeField] GameObject[] tiles;
    float timer;
    //Timer
    [SerializeField] TextMeshProUGUI timerInGameTextGUI;
    float timerInGame = 0;
    // Start is called before the first frame update
    void Start()
    {
        timer = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        timer-=Time.deltaTime;
        if(timer < 0)
        {
            Instantiate(tiles[Random.Range(0, tiles.Length)],new Vector2(Random.Range(-11.5f,11.5f),8),Quaternion.identity);
            timer = 2f;
        }
        timerInGame += Time.deltaTime;
        timerInGameTextGUI.text = string.Format("{0}:{1:00}", (int)timerInGame / 60, (int)timerInGame % 60);
    }
}
