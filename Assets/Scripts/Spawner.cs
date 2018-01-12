using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    /*
     * De claramos variables publicas para:
     * 1. El prefab del enemigo que vamos a instanciar.
     * 2. El intervalo de tiempo en segundos entre la aparición de cada enemigo.
     * 3. La cantidad de enemigos a instanciar.
     * 4. La velocidad de movimiento de los enemigos.
     */

	void Start () {
        //Disparamos la co-rutina.
	}

    /*
     * Co-rutina que instancia enemigos.
     */
    private IEnumerator spawn() {
        //Iteramos por la cantidad de enemigos a instanciar (variable pública).

            //Instanciamos un enemigo y nos guardamos la referencia al GameObject instanciado.

            //Le damos al enemigo una posición random en el escenario.

            //Le damos al enemigo una rotación random en el escenario.

            //Le agregamos al enemigo el script de tipo Destruible, el cual le agrega el comportamiento de ser destruido cuando lo toca un proyectil.

            //Le agregamos un Rigidbody y un BoxCollider al enemigo para que pueda tener física. 

            //Al Rigidbody le desactivamos la gravedad y al collider lo configuramos como trigger.

            //Le aplicamos una cantidad de fuerza hacia adelante para que el enemigo se mueva. Usar variable pública.

            //Detenemos la ejecución y esperamos la cantidad de tiempo configurada en la variable pública correspondiente.

        //Terminamos la ejecución.
    }
}
