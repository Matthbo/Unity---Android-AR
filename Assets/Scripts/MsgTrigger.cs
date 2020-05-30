using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MsgTrigger : MonoBehaviour
{
    private void Start()
    {
        this.gameObject.GetComponent<Button>().onClick.Invoke();
    }
}
