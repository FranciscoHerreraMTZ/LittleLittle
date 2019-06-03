using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    public string Esencena;

	public void Iniciar()
    {
        Application.LoadLevel(Esencena);
    }
    public void Salir()
    {
        Application.Quit();
    }

}
