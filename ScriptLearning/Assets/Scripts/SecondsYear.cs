using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondsYear : MonoBehaviour
{
    /// <summary>
    /// 1年は31536000秒
    /// </summary>

    public int Year;
    void Start()
    {
        Debug.Log(Year * 31536000);
    }
}
