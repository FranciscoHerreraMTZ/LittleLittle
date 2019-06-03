using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenudeMuerte : MonoBehaviour {

    public string Menu;

    public void ReiniciarJuego()
    {
        FindObjectOfType<Manejador>().Reinicio();
    }
    public void SalirAlMenu()
    {
        Application.LoadLevel(Menu);

    }
}
