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
        hig.text = "Primer lugar: " + Mathf.Round(PlayerPrefs.GetFloat("PuntuacionMaxima"));
        hig2.text = "Segundo lugar: " + Mathf.Round(PlayerPrefs.GetFloat("Segundo"));
        hig3.text = "Tercero lugar: " + Mathf.Round(PlayerPrefs.GetFloat("Tercero"));
        hig4.text = "Cuarto lugar: " + Mathf.Round(PlayerPrefs.GetFloat("Cuarto"));
        hig5.text = "Quinto lugar: " + Mathf.Round(PlayerPrefs.GetFloat("Quinto"));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
