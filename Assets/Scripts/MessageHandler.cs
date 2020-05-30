using System;
using UnityEditor;
using UnityEngine;

public class MessageHandler : MonoBehaviour
{
    public void SetMessage(string msg)
    {
        this.gameObject.GetComponent<App>().Message = msg;
    }

    public void PrintMessage()
    {
        Debug.Log("MESSAGE: " + this.gameObject.GetComponent<App>().Message);
    }
}
