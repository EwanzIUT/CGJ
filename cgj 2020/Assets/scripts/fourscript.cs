using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fourscript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col){
    	if (col.gameObject.CompareTag("mort")){
    		Debug.Log("ça marche ?");
    		Destroy(col.gameObject);
    		Timer.setStop(true);
    	}
    }
}
