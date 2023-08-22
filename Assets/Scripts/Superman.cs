using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superman : MonoBehaviour {

    public Rigidbody superman;
    public float power;

    private void Start() {
    }

    private void FixedUpdate() {
        superman.AddForce(0, 0, 10, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision) {

        GameObject guy = collision.gameObject;

        if(guy.layer == 11) {
            Vector3 direction = guy.transform.position - superman.transform.position;
            guy.GetComponent<Rigidbody>().AddForce(direction * power, ForceMode.Impulse);
        }

    }

}
