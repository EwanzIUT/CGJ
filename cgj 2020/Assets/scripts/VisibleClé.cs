using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleClé : MonoBehaviour
{

	public GameObject cle;
	public static bool affiche = false; //Permet de gérer l'affichage de la clé

    // Start is called before the first frame update
    void Start()
    {
    	cle.SetActive(false); //On initialise l'affichage sur faux (caché)
    }

    public static void afficheCle() {
    	Debug.Log("Passage )");
    	VisibleClé.affiche = true; 
    }

    // Update is called once per frame
    void Update()
    {
    	if (affiche) {
    		Debug.Log("Hey");
    		cle.SetActive(true); //On lui fait afficher la clé 
    		return; //Pas sûre de son utilité 
    	}
    }
}

/*var player : Transform;
 var chunk1 : GameObject;
 
 function Update () {
     var dist : float = Vector3.Distance(chunk1.transform.position, transform.position);
     
     if(dist >= 50){
         chunk1.SetActive (false);
         
     } else if (dist <= 50){
         chunk1.SetActive (true);
     }
     Debug.Log(dist);
 }   
*/