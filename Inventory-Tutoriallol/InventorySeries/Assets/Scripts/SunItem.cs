using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunItem : MonoBehaviour {

    private Transform player;
    private Transform biche;
    public GameObject explosionEffect;

    private void Start()
    {
        biche = GameObject.FindGameObjectWithTag("Biche").transform;
    }

    public void Use() {
        Instantiate(explosionEffect, biche.transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(GameObject.FindGameObjectWithTag("Biche"));

    }

}
