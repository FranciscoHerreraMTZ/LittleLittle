using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salto : MonoBehaviour {
    public float movimiento;
    private float movimientoOriginal;
    public float fuerzasalto;
    public float MultiplicadorDeVelocidad;

    public float incrementadorDeVelocidad;
    private float MedidorDeVelocidad;
    private float OriginalMedidorDeVelocidad;
    private float OriginalincrementadorDeVelocidad;



    private Rigidbody2D myRigibody2d;

    public bool ground;
    public LayerMask QueEsSuelo;
    public Transform comprobadorDeSuelo;
    public float RadioDelComprobador;

    private bool dobleSalto;


    private CircleCollider2D micolision;

    private Animator mianimador;


    public Manejador maneja;

    public AudioSource sonidoDeSalto;
    public AudioSource SonidoDeMuerte;


    // Use this for initialization
    void Start () {
        myRigibody2d = GetComponent<Rigidbody2D>();

        micolision = GetComponent<CircleCollider2D>();

        mianimador = GetComponent<Animator>();

        movimientoOriginal = movimiento;
        OriginalMedidorDeVelocidad = MedidorDeVelocidad;
        OriginalincrementadorDeVelocidad = incrementadorDeVelocidad;

    }
	
	// Update is called once per frame
	void Update () {

        //ground = Physics2D.IsTouchingLayers(micolision, QueEsSuelo);
        ground = Physics2D.OverlapCircle(comprobadorDeSuelo.position, RadioDelComprobador, QueEsSuelo);

        if(transform.position.x> MedidorDeVelocidad)
        {
            MedidorDeVelocidad += incrementadorDeVelocidad;

            incrementadorDeVelocidad = incrementadorDeVelocidad * MultiplicadorDeVelocidad;

            movimiento = movimiento * MultiplicadorDeVelocidad;
        }

        myRigibody2d.velocity = new Vector2(movimiento, myRigibody2d.velocity.y);


        if (Input.touchCount > 0&& Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (ground)
            {
                myRigibody2d.velocity = new Vector2(myRigibody2d.velocity.x, fuerzasalto);
                dobleSalto = true;
                sonidoDeSalto.Play();
            }
            if (!ground && dobleSalto )
            {
                myRigibody2d.velocity = new Vector2(myRigibody2d.velocity.x, fuerzasalto);
                dobleSalto = false;
                sonidoDeSalto.Play();

            }
        }

        mianimador.SetFloat("Speed",myRigibody2d.velocity.x);
        mianimador.SetBool("Ground", ground);

    }
    private void OnCollisionEnter2D(Collision2D otra)
    {
        if (otra.gameObject.tag == "killbox")
        {
            maneja.RestartGame();
            movimiento = movimientoOriginal;
            MedidorDeVelocidad = OriginalMedidorDeVelocidad;
            incrementadorDeVelocidad = OriginalincrementadorDeVelocidad;
            SonidoDeMuerte.Play();
        }
    }
}
