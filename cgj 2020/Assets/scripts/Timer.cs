using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{


	 public float timeLeft;
	 public float temps;
	 public Text timeDisplay;
	 public static bool stop = false;
	 public static bool fin = false; 

	 void Start()
	 {
	 	timeLeft = 12.0f;
	 }

	 public static void setStop (bool b) {
	 	Timer.stop = b;
	 }

	 public static void setFin (bool c) {
	 	Timer.fin = c;
	 }

    // Update is called once per frame
     void Update()
     {
     	if(stop && fin) return;
     	 timeLeft -= Time.deltaTime;	
     	 timeDisplay.text = "Temps restant " + Mathf.Round(timeLeft).ToString();
         if(timeLeft < 0 | fin)
         {
             stop = true;
             timeDisplay.text = "Game Over";
             fin = true; 
         } else if(stop) {
     	 	timeDisplay.text = "Bravo";
     	 	VisibleClé.afficheCle();
     	 	fin = true; 
     	 	return;
     	 } 

     }


}
