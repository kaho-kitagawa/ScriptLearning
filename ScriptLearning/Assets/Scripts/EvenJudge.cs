using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenJudge : MonoBehaviour
{
    public int Number;
    void Start()
    {
        if (Number % 2 == 0)
        {
            Debug.Log("偶数");
        }
        else
        {
            Debug.Log("奇数");
        }
    }

}
