using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageItem : MonoBehaviour {

    private Transform player;
    private Transform cage;
    public GameObject explosionEffect;

    private void Start()
    {
        cage = GameObject.FindGameObjectWithTag("Cage").transform;
    }

    public void Use() {
        Instantiate(explosionEffect, cage.transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(GameObject.FindGameObjectWithTag("Cage"));
    }

}
