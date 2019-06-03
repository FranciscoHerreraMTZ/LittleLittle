using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour {

    public GameObject Plataformas;
    public Transform puntodeReferencia;
    public float DistanciaEntrePlataformas;

    private float platformWidth;

    public float DistanciaEntrePlataformasMin;
    public float DistanciaEntrePlataformasMax;

    public GameObject[] lasPlataformas;

    private int selector;
    private float[] plataformawdth;

    private float minimaaltura;
    public Transform MaximoAltura;
    private float MaxAltura;
    public float maximocambio;
    private float cambio;

    // Use this for initialization
    void Start () {
        // platformWidth = Plataformas.GetComponent<BoxCollider2D>().size.x;
        plataformawdth = new float[lasPlataformas.Length];
        for(int i = 0; i < lasPlataformas.Length; i++)
        {
            plataformawdth[i] = lasPlataformas[i].GetComponent<BoxCollider2D>().size.x;
        }

        minimaaltura = transform.position.y;
        MaxAltura = MaximoAltura.position.y;

	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x < puntodeReferencia.position.x)
        {

            DistanciaEntrePlataformas = Random.Range(DistanciaEntrePlataformasMin, DistanciaEntrePlataformasMax);

            selector = Random.Range(0, lasPlataformas.Length);

            cambio = transform.position.y + Random.Range(maximocambio, -maximocambio);
            if (cambio > MaxAltura)
            {
                cambio = MaxAltura;
            }else if(cambio < minimaaltura)
            {
                cambio = minimaaltura;
            }

            transform.position = new Vector3(transform.position.x + plataformawdth[selector] + DistanciaEntrePlataformas,  cambio, transform.position.z);

            

           Instantiate(lasPlataformas[selector], transform.position, transform.rotation);
        }
	}
}
