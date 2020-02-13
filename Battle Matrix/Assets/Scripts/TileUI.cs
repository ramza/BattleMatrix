using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TileUI : MonoBehaviour, IPointerClickHandler
{

    public Image cursorImage;
    public Image tileImage;
    

    public void OnPointerClick(PointerEventData eventData)
    {
        cursorImage.gameObject.SetActive(true);
        cursorImage.sprite = tileImage.sprite;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
