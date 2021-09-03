using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question2 : MonoBehaviour
{
    public int Year;
    void Start()
    {
        if (Year % 400 == 0)
        {
            Debug.Log("うるう年だよ");
        }
        else if (Year % 100 == 0)
        {
            Debug.Log("うるう年じゃないよ");
        }
        else if (Year % 4 == 0)
        {
            Debug.Log("うるう年だよ");
        }
        else
        {
            Debug.Log("うるう年じゃないよ");
        }
    }
}
