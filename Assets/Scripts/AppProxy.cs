using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppProxy : MonoBehaviour
{

    public void LoadScene(string sceneName)
    {
        App.Instance.LoadScene(sceneName);
    }

    public void SaveSpawnedObjs()
    {
        App.Instance.SaveSpawnedObjs();
    }

    public void LoadSpawnedObjs()
    {
        App.Instance.LoadSpawnedObjs();
    }
}
