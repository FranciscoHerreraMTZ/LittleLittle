using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManejadorPuntuacion : MonoBehaviour {
    public Text Puntaje;
    public Text PuntajeMaximo;

    public float PuntajeContador;
    public float PuntajeMaximoContador;

    public float SegundoLugar;
    public float TercerLugar;
    public float CuartoLugar;
    public float QuintoLugar;

    public float puntosPorSegundos;

    public bool Aumentador;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetFloat("PuntuacionMaxima") != 0)
        {
            PuntajeMaximoContador = PlayerPrefs.GetFloat("PuntuacionMaxima");
            SegundoLugar = PlayerPrefs.GetFloat("Segundo");
            TercerLugar = PlayerPrefs.GetFloat("Tercero");
            CuartoLugar = PlayerPrefs.GetFloat("Cuarto");
            QuintoLugar = PlayerPrefs.GetFloat("Quinto");


        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Aumentador)
        {
            PuntajeContador += puntosPorSegundos * Time.deltaTime;
        }
        if (PuntajeContador >= PuntajeMaximoContador)
        {
            PuntajeMaximoContador = PuntajeContador;
            PlayerPrefs.SetFloat("PuntuacionMaxima", PuntajeMaximoContador);
        }
        else if (PuntajeContador < PuntajeMaximoContador)
        {
            if (PuntajeContador >= SegundoLugar)
            {
                SegundoLugar = PuntajeContador;
                PlayerPrefs.SetFloat("Segundo", SegundoLugar);
            }
            else if (PuntajeContador < SegundoLugar)
            {
                if (PuntajeContador >= TercerLugar)
                {
                    TercerLugar = PuntajeContador;
                    PlayerPrefs.SetFloat("Tercero", TercerLugar);
                }
                else if (PuntajeContador < TercerLugar)
                {
                    if (PuntajeContador >= CuartoLugar)
                    {
                        CuartoLugar = PuntajeContador;
                        PlayerPrefs.SetFloat("Cuarto", CuartoLugar);
                    }
                    else if (PuntajeContador < CuartoLugar)
                    {
                        if (PuntajeContador >= QuintoLugar)
                        {
                            QuintoLugar = PuntajeContador;
                            PlayerPrefs.SetFloat("Quinto", QuintoLugar);
                        }
                    }
                }
            }
        }
       
       

       

        Puntaje.text = "Puntaje: " + Mathf.Round(PuntajeContador);
        PuntajeMaximo.text = "Puntuacion Maxima: " + Mathf.Round(PuntajeMaximoContador);
	}
    public void AgregarPuntaje(int monedas)
    {
        PuntajeContador += monedas;
    }
}
