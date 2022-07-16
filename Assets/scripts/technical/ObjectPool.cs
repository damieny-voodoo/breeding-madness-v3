using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool SharedInstance;
    public Dictionary<string, List<GameObject>> pooledObjects;
    public GameObject[] objectToPool;
    public int[] amountToPool;

    /*
    Dictionary<string, List<GameObject>>
*/

    private void Awake()
    {
        SharedInstance = this;
        CreatePool();
    }


    void CreatePool()
    {
        pooledObjects = new Dictionary<string, List<GameObject>>();
        GameObject tmp;

        /////////////////// ITEMS
        for (int j = 0; j < objectToPool.Length; j++)
        {
            if (objectToPool[j])
            {
                pooledObjects.Add(objectToPool[j].name, new List<GameObject>());

                for (int i = 0; i < amountToPool[j]; i++)
                {
                    tmp = Instantiate(objectToPool[j]);
                    tmp.SetActive(false);
                    tmp.transform.SetParent(transform);
                    tmp.name = objectToPool[j].name;
                    pooledObjects[objectToPool[j].name].Add(tmp);
                }
            }
        }


        /////////////////// ITEMS


    }

    public GameObject GetPooledObject(string objectName)
    {
        //Debug.Log("Get pooled object: "+objectName);
        if(!pooledObjects.TryGetValue(objectName, out List<GameObject> objects))
        {
            Debug.LogError("Object pooled not found: "+ objectName);
            return null;
        }
        
        if( objects.Count == 1)
        {
           AddObjectToPool(objectName);
        }
        
        GameObject pooledObject = objects[0];
        objects.RemoveAt(0);

        return pooledObject;
    }

    public void ReleaseObject(GameObject releasedObject)
    {
        //Debug.Log("Release object " + releasedObject.name);
        releasedObject.SetActive(false);
        releasedObject.transform.SetParent(transform);

        pooledObjects[releasedObject.name].Add(releasedObject);

    }


    void AddObjectToPool(string objectName)
    {

       // pooledObjects.Add(objectName, new List<GameObject>());
        //bool itemFound = false;
        GameObject tmp;

        for (int i=0; i < objectToPool.Length; i++)
        {
            if (objectToPool[i])
            {
                if(objectToPool[i].name == objectName)
                {
                    tmp = Instantiate(objectToPool[i]);
                    tmp.SetActive(false);
                    tmp.transform.SetParent(transform);
                    tmp.name = objectToPool[i].name;
                    pooledObjects[objectToPool[i].name].Add(tmp);
                }
            }


        }


    }


    /*
    int objectId(string idToCheck)
    {
        int id = 0;
        for(int i=0;i< objectToPool.Length;i++)
        {
            if (idToCheck == objectToPool[i].name)
                id = i;
        }
        return id;
    }
    */
}
