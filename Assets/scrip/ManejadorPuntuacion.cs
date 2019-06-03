using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManejadorPuntuacion : MonoBehaviour {
    public Text Puntaje;
    public Text PuntajeMaximo;

    public float PuntajeContador;
    public float PuntajeMaximoContador;

   
    public float puntosPorSegundos;

    public bool Aumentador;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetFloat("PuntuacionMaxima") != 0)
        {
            PuntajeMaximoContador = PlayerPrefs.GetFloat("PuntuacionMaxima");
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Aumentador)
        {
            PuntajeContador += puntosPorSegundos * Time.deltaTime;
        }
        if (PuntajeContador > PuntajeMaximoContador)
        {
            PuntajeMaximoContador = PuntajeContador;
            PlayerPrefs.SetFloat("PuntuacionMaxima", PuntajeMaximoContador);
        }
       
       

       

        Puntaje.text = "Puntaje: " + Mathf.Round(PuntajeContador);
        PuntajeMaximo.text = "Puntuacion Maxima: " + Mathf.Round(PuntajeMaximoContador);
	}
    public void AgregarPuntaje(int monedas)
    {
        PuntajeContador += monedas;
    }
}
