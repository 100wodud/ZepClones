using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public Text Time;
    // Start is called before the first frame update
    void Start()
    {
        Time.text = "12:00:00";
    }

    // Update is called once per frame
    void Update()
    {
        string time = GetCurrentDate();
        if(time != null)
        {
            Time.text = time;
        } else
        {
            Time.text = "00:00:00";
        }
    }
    public static string GetCurrentDate()
    {
        return DateTime.Now.ToString(("HH:mm:ss"));
    }
}
