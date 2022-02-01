using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary></summary>
public class commandScript : MonoBehaviour
{
    public int GenerateNum;
    public int num;
    [SerializeField] GameObject AllUiObj;
    public GameObject[] UiObj = new GameObject[10];
    /// <summary>コマンドの現在位置</summary>
    public Transform[] UiPos = new Transform[10];
}
