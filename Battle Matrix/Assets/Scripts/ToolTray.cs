using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTray : MonoBehaviour
{

    public GameObject tilesCanvas;

    bool tilesON;

    // Start is called before the first frame update
    void Start()
    {
        tilesCanvas.SetActive(false);
    }

    public void ToggleTilesCanvas()
    {
        tilesON = !tilesON;
        tilesCanvas.SetActive(tilesON);
    }
}
