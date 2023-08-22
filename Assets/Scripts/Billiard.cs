using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billiard : MonoBehaviour {

    public float kickPower;
    public Rigidbody mainBall;

    void Start() {
        mainBall.AddForce(0, 0, kickPower, ForceMode.Impulse);
    }

    void Update() {

    }

}
