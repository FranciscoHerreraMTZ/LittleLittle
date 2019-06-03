using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manejador : MonoBehaviour {
    public Transform generador;
    private Vector3 inicioDeLaPlataforma;

    public salto Jugador;
    private Vector3 InicioDelJugador;

    private Destructor[] listaDePlataformas;

    private ManejadorPuntuacion Marcador;

    public MenudeMuerte menu;

	// Use this for initialization
	void Start () {
        inicioDeLaPlataforma = generador.position;
        InicioDelJugador = Jugador.transform.position;

        Marcador = FindObjectOfType<ManejadorPuntuacion>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void RestartGame()
    {
        Marcador.Aumentador = false;
        Jugador.gameObject.SetActive(false);
        // StartCoroutine("RestartGameCo");
        menu.gameObject.SetActive(true);
    }
    public void Reinicio()
    {
        listaDePlataformas = FindObjectsOfType<Destructor>();
        for (int i = 0; i < listaDePlataformas.Length; i++)
        {
            listaDePlataformas[i].gameObject.SetActive(false);
        }


        Jugador.transform.position = InicioDelJugador;
        generador.position = inicioDeLaPlataforma;
        Jugador.gameObject.SetActive(true);

        Marcador.PuntajeContador = 0;
        Marcador.Aumentador = true;
        menu.gameObject.SetActive(false);
    }
   /* public IEnumerator RestartGameCo()
    {
        Marcador.Aumentador = false;
        Jugador.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        listaDePlataformas = FindObjectsOfType<Destructor>();
        for(int i= 0; i < listaDePlataformas.Length; i++)
        {
            listaDePlataformas[i].gameObject.SetActive(false);
        }


        Jugador.transform.position = InicioDelJugador;
        generador.position = inicioDeLaPlataforma;
        Jugador.gameObject.SetActive(true);

        Marcador.PuntajeContador = 0;
        Marcador.Aumentador = true;

    }*/
}
