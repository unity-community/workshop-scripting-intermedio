using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour {

    public GameObject proyectil;
    
    private RaycastHit hit;
    private Animator animator;
    private bool aim;
    private GameObject target;
    private Transform puntaArma;

	void Start () {
        animator = GetComponent<Animator>();
        puntaArma = transform.Find("Arma");
	}

	void Update () {
        //Tiro un raycast y si le pega a algo Y no le estoy apuntando a otro enemigo
            //Desactivo el animator para detener la animación de rotación de la torreta
            //En la variable target pongo el objeto al cual le pegó el raycast.
            //Pongo la variable aim en true para no seguir buscando enemigos
            //Disparo la co-rutina 'destruir'.
        //Si estoy apuntando (si aim está en true) y hay un objetivo, hago que la torreta mire hacia el objetivo
	}

    /*
     * Creamos una co-rotina 'destruir' que haga lo siguiente:
     * 1. Detenemos la ejecución 1 segundo para darle tiempo de 'apuntar' a la torreta.
     * 2. Llamamos al método disparar
     * 3. Detenemos la ejecución 0.5 segundos para darle tiempo al proyectil a que destruya al enemigo.
     * 4. Seteamos aim en false y el target en null
     * 5. Volvemos a habilitar el animator así la torreta vuelve a buscar rotar en busca de enemigos.
     * 6. Cortamos la ejecución de la co-rutina
     */
     
    /*
     * Creamos un método 'disparar' que haga lo siguiente:
     * 1. Instanciamos el proyectil
     * 2. Al proyectil instanciado le damos la posición y la rotación de la punta del arma (variable).
     * 3. Al proyectil le agregamso una fuerza hacia adelante.
     */


}
