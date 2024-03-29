using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        other.gameObject.GetComponent<Rigidbody>().useGravity = false;
    }

    private void OnTriggerExit(Collider other) {
        other.gameObject.GetComponent<Rigidbody>().useGravity = true;
    }

}
