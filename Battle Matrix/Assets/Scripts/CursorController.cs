using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CursorController : MonoBehaviour
{
    Camera _camera;
    public GameObject cursorImage;
    TilePaint tilePaint;

    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
        cursorImage.SetActive(false);
        tilePaint = GetComponent<TilePaint>();
    }

    // Update is called once per frame
    void Update()
    {
        var v3 = Input.mousePosition;
        v3.z = 0f;

        cursorImage.transform.position = Input.mousePosition;
    }

    public void ActivateTilePaint()
    {

    }
}
