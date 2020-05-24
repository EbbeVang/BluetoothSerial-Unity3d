using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using System;

public class grabValue : MonoBehaviour
{
    public int value;
    private GameObject bluetooth;

    // Start is called before the first frame update
    void Start()
    {
        bluetooth = GameObject.FindWithTag("BT");
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            value = Int32.Parse(bluetooth.GetComponent<SerialConnection>().lastReadMessage);
        }
        catch (Exception)
        {

            throw;
        }
        
    }
}
