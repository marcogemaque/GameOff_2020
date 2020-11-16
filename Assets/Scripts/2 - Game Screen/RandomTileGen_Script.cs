using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTileGen_Script : MonoBehaviour
{
    /*Script created to generate 10x10 grids to emulate a Tower Defense system.
     * This script holds:
     * Original Tile Object
     */

    public GameObject tile;

    public void Start()
    {
        for (int i = 0; i < 10; i++) //10 rows
        {
            for (int j = 0; j < 10; j++) //10 columns
            {
                var newObject = Instantiate(tile, new Vector3(0, 100 * i, 100 * j), tile.transform.localRotation);
            }
        }
    }
}