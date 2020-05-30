using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MsgTrigger2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject app = GameObject.FindWithTag("App");
        app.GetComponent<MessageHandler>().PrintMessage();
    }
}
