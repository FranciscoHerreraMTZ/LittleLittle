using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformas2 : MonoBehaviour {
    public GameObject plataforma;
    public Transform generador;
    public float distancia;

    private float width;
	// Use this for initialization
	void Start () {
        width = plataforma.GetComponent<BoxCollider2D>().size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < generador.position.x)
        {
            transform.position = new Vector3(transform.position.x + width, distancia);

            Instantiate(plataforma, transform.position, transform.rotation);
        }
	}
}
