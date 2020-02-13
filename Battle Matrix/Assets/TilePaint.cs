using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TilePaint : MonoBehaviour
{
    public GameObject tileObject;
    public Image imageCursor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                
                if (hit.transform.tag == "Tile")
                {
                    print("paint tile");
                    hit.transform.GetComponentInChildren<SpriteRenderer>().sprite = imageCursor.sprite;
                }
                //Debug.Log(hit);
            }

        }

        else if (Input.GetMouseButton(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {

                if (hit.transform.tag == "Tile")
                {
                    print("paint tile");
                    hit.transform.GetComponentInChildren<SpriteRenderer>().sprite = null;
                }
                //Debug.Log(hit);
            }

        }
    }
}
