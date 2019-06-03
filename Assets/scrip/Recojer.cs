using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recojer : MonoBehaviour {

    public int puntosQueDa;

    private ManejadorPuntuacion Marcador;

    private AudioSource sonidoDeMoneda;
	// Use this for initialization
	void Start () {
        Marcador = FindObjectOfType<ManejadorPuntuacion>();
        sonidoDeMoneda = GameObject.Find("Coin").GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D otro)
    {
        if(otro.gameObject.name == "Player")
        {
            Marcador.AgregarPuntaje(puntosQueDa);
            gameObject.SetActive(false);

            sonidoDeMoneda.Play();
        }
    }
}
