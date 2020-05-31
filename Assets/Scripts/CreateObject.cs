using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{

    public List<GameObject> createdObjects = new List<GameObject>();

    public void Create(GameObject objToSpawn)
    {
        if (objToSpawn != null)
        {
            GameObject obj = Instantiate(objToSpawn, new Vector3(0, 0, 10), Quaternion.identity);
            obj.name = objToSpawn.name;
            obj.tag = "Spawned";
            createdObjects.Add(obj);
        }
    }

    public void DeleteAll()
    {
        foreach (var obj in createdObjects)
        {
            Destroy(obj);
        }
        createdObjects.Clear();
    }
}
