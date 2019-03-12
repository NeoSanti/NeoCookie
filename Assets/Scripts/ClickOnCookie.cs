using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickOnCookie : MonoBehaviour
{
    GameManager gm;
    public Canvas canvas;
    public GameObject plusIndicator;
    Vector3 mousePos;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    void OnMouseDown()
    {
        Instantiate(plusIndicator, new Vector3(mousePos.x, mousePos.y, -0.1f), Quaternion.identity, canvas.transform);
        transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        gm.currentNumber += gm.AddNumber;
    }

    void OnMouseUp()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
