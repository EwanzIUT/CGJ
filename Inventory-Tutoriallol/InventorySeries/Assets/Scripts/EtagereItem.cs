using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EtagereItem : MonoBehaviour {

    private Transform player;
    private Transform fiole;
    public GameObject explosionEffect;
    public static boolean tombe;

    private void Start()
    {
        fiole = GameObject.FindGameObjectWithTag("Etagere").transform;
        tombe=false;
    }

    public void Use() {
        Instantiate(explosionEffect, fiole.transform.position, Quaternion.identity);
        Destroy(gameObject);
        fiole.transform.position = Vector2.down * 5f;
        tombe=true;
    }

}
