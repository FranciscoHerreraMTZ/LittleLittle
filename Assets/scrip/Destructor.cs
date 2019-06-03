using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour {
    public GameObject puntoDeDestruccion;
	// Use this for initialization
	void Start () {
        puntoDeDestruccion = GameObject.Find("Destructor");
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < puntoDeDestruccion.transform.position.x)
        {
            Destroy(gameObject);
          
        }
	}
}
