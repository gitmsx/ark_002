using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickmanager : MonoBehaviour


{


    public int rows;
    public int cols;
    public float spacing;
    public GameObject brickprefab;


    private List<GameObject> bricks = new List<GameObject> ();

    // Start is called before the first frame update
    void Start()
    {
        ResetLevel();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void ResetLevel()
    {
        foreach (GameObject brick in bricks)
            Destroy(brick);
        bricks.Clear();
        
        for (int x = 0; x <= cols; x++)
        {
            for (int y = 0; y <= rows; y++)
            {
                Vector2 spawnpos = (Vector2)transform.position + new Vector2(
                    x * (brickprefab.transform.localScale.x + spacing), -y * (brickprefab.transform.localScale.y + spacing));

                GameObject brick = Instantiate(brickprefab, spawnpos, Quaternion.identity);
                bricks.Add(brick);


                
                ;
            }
        }
    }
}


