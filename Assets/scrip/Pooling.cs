using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooling : MonoBehaviour {
    public GameObject pool;

    public int poolAmount;

    List<GameObject> poolObjects;

	// Use this for initialization
	void Start () {
        poolObjects = new List<GameObject>();

        for(int i = 0; i< poolAmount; i++)
        {
          //  GameObject obj = Instantiate(poolObjects);
         //   obj.SetActive(false);
          //  poolObjects.Add(obj);
        }
	}
	
	
}
