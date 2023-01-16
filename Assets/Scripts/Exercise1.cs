using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    private float value1;
    private float value2;
    private float value3;

    private void Start()
    {
        Summons(value1,value2,value3);
    }

    private float Summons(float x, float y, float z)
    {
        
        float result = (x + y + z) / 3;
        Debug.Log($"result = {result}");
        return result;
    }
}
