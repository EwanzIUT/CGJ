using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinWitch : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D tri){
    	if (tri.gameObject.CompareTag("mort")){
    		Debug.Log("ça marche ?");
    		Destroy(tri.gameObject);
    		Timer.setFin(true);
    	}
    }
}
