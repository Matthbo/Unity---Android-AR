using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class App : Singleton<App>
{
    public string Message { get; set; }
    public GameObject[] loadableObjects;

    private List<SavedObjects> SavedObjs;
    
    public void Start()
    {
        Debug.Log("Starting App");
        
        SavedObjs = new List<SavedObjects>();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void SaveSpawnedObjs()
    {
        SavedObjs.Clear();
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Spawned");

        foreach (var obj in objs)
        {
            SavedObjs.Add(new SavedObjects(obj.name, obj.transform.position, obj.transform.rotation));
            Debug.Log("Saved object");
        }
        
        Debug.Log(SavedObjs.Count);
    }

    public void LoadSpawnedObjs()
    {
        SavedObjs.ForEach(savedObj =>
        {
            var prefab = Array.Find(loadableObjects, obj => obj.name == savedObj.Name);
            var gObj = Instantiate(prefab);

            gObj.name = savedObj.Name;
            gObj.transform.position = savedObj.Position;
            gObj.transform.rotation = savedObj.Rotation;
            
            Debug.Log("Loaded object");
        });
    }

    public class SavedObjects
    {
        public String Name { get; }
        public Vector3 Position { get; }
        public Quaternion Rotation { get; }

        public SavedObjects(String name, Vector3 position, Quaternion rotation)
        {
            this.Name = name;
            this.Position = position;
            this.Rotation = rotation;
        }
    }
}
