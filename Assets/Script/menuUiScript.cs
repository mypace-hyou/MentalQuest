using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary></summary>
public class menuUiScript : MonoBehaviour
{
    [Header("UIの表示位置の番号(最初は0)")]
    public int Uinumber;
    commandScript S_com;
    public GameObject G_com;
    bool ocCH;

    public GameObject uiObj;
    void Start()
    {
        S_com = FindObjectOfType<commandScript>();
        S_com.UiObj[Uinumber] = gameObject;
        S_com.UiPos[Uinumber] = transform;
        S_com.num += 1;
    }
    public void openUi()
    {
        if (ocCH == true)
        {
            uiObj.gameObject.SetActive(true);
        }
        if (ocCH == false)
        {
            uiObj.gameObject.SetActive(false);
        }
    }
}
