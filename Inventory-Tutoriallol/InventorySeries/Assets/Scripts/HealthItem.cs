﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour {

    private PlayerController player;
    public GameObject healthEffect;
    

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    public void Use() {
        Instantiate(healthEffect, player.transform.position, Quaternion.identity);
                Destroy(gameObject);
    }
}
