using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldTiles : MonoBehaviour
{

    public GameObject tilePrefab;

    public float tileMapWidth = 20;
    public float tileMapHeight = 10;
    public float tileSize = 1f;

    Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition.x = -1 * tileMapWidth / 2 * tileSize;
        startPosition.z = -1 * tileMapHeight / 2 * tileSize;
        // draw all the tiles we can paint with the tile editor
        DrawTiles();
    }

    void DrawTiles()
    {
        for ( int i = 0; i < tileMapWidth; i++)
        {
            for ( int j = 0; j < tileMapHeight; j++)
            {
                Instantiate(tilePrefab, new Vector3(startPosition.x+i * tileSize, 0, startPosition.z+j * tileSize), Quaternion.identity);
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
