using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguimiento : MonoBehaviour {
    public salto jugador;

    private Vector3 UltimaPosicion;
    private float distanciaAMover;
	// Use this for initialization
	void Start () {
        jugador = FindObjectOfType<salto>();
        UltimaPosicion = jugador.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        distanciaAMover = jugador.transform.position.x - UltimaPosicion.x;

        transform.position = new Vector3(transform.position.x + distanciaAMover, transform.position.y, transform.position.z);

        UltimaPosicion = jugador.transform.position;
	}
}
