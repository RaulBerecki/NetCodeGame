using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    [SerializeField] GameObject[] tiles;
    float timer;
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
    }
}
