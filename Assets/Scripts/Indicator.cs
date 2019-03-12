using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour
{
    GameManager gm;
    public float moveSpeed;
    public TMPro.TextMeshProUGUI Text;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1);
        Text = GetComponent<TMPro.TextMeshProUGUI>();
        gm = FindObjectOfType<GameManager>();
        Text.text = "+" + gm.currentBase * gm.currentMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        Text.color -= new Color(0f, 0f, 0f, 0.018f);
    }
}
