using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magico : MonoBehaviour {

    public GameObject[] obj;
    public float spawnMin = 1f;
    public float spawnMax = 2f;
    public float cambiaalturamaxima = 2f;
    public float cambiaalturaminima = -3f;
    public float cambiaaltura;

    private float minima;
    public Transform maxpoint;
    private float alturamax;
    private float cambio;

    // Use this for initialization
    void Start () {
        Spawn();
        minima = transform.position.y;
        alturamax = maxpoint.position.y;
            
	}
	
	
    void Spawn()
    {
        cambio = transform.position.y + Random.Range(cambiaalturamaxima, cambiaalturaminima);
        cambiaaltura = Random.Range(cambiaalturamaxima, cambiaalturaminima);
        if (cambio > cambiaalturamaxima)
        {
            cambio = cambiaalturamaxima;
        }else if(cambio < cambiaalturaminima)
        {
            cambio = cambiaalturaminima;
        }
        transform.position = new Vector3(transform.position.x,transform.position.y + cambio);
        
        Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
        transform.position = new Vector3(transform.position.x, minima);

        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
    }
}
