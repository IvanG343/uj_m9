using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public float timeToExplosion;
    public float power;
    public float radius;

    private Rigidbody[] elements;

    void Start() {
        elements = FindObjectsOfType<Rigidbody>();
    }

    void Update() {
        timeToExplosion -= Time.deltaTime;

        if(timeToExplosion <= 0) {
            Boom();
            timeToExplosion = 3;
        }
    }

    private void Boom() {
        foreach(Rigidbody element in elements) {
            Debug.Log("Boom!");
            if(Vector3.Distance(transform.position, element.transform.position) < radius) {
                Vector3 direction = element.transform.position - transform.position;
                element.AddForce(direction * power, ForceMode.Impulse);
            }
        }
    }

}
