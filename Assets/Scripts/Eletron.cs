using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Eletron : MonoBehaviour
{
    private float randomVelocity;

    private void Start() {
        randomVelocity = Random.Range(40, 80);
    }

    private void Update() {
        transform.RotateAround(transform.parent.position, transform.up, randomVelocity * Time.deltaTime);
    }
}
