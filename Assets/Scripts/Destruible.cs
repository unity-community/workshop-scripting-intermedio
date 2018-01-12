using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruible : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Bala") {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

}
