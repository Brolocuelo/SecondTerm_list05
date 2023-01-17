using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    private string admin;
    private string abccba;

    private void Start()
    {
        Login(admin,abccba);
    }

    private bool Login(string x, string y)
    {
        if ( ((x =="admin") && (y=="abccba")))
        {
            Debug.Log(true);
            return true;
        }
        else
        {
            return false;
        }
    }
}
