using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-.03f,0);
        if (transform.position.y < -10)
            Destroy(gameObject);
    }
}
