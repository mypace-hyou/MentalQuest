using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemUiScript : MonoBehaviour
{
    [Header("UIの表示位置の番号(最初は0)")]
    public int number;
    commandScript S_com;
    public GameObject G_com;
    // Start is called before the first frame update
    void Start()
    {
        S_com = FindObjectOfType<commandScript>();
        G_com = gameObject;
        S_com.UiPos[number] = transform;
        S_com.UiObj[number] = gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
