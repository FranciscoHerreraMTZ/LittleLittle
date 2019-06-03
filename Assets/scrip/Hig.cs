using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hig : MonoBehaviour {
    public Text hig;
    public Text hig2;
    public Text hig3;
    public Text hig4;
    public Text hig5;

    private float puntuacion;
	// Use this for initialization
	void Start () {
        hig.text = "Primer lugar" + PlayerPrefs.GetFloat("PuntuacionMaxima");
        hig2.text = "Segundo lugar" + PlayerPrefs.GetFloat("PuntuacionMaxima2");
        hig3.text = "Tercero lugar" + PlayerPrefs.GetFloat("PuntuacionMaxima3");
        hig4.text = "Cuarto lugar" + PlayerPrefs.GetFloat("PuntuacionMaxima4");
        hig5.text = "Quinto lugar" + PlayerPrefs.GetFloat("PuntuacionMaxima5");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
