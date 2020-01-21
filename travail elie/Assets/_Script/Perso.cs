using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perso : MonoBehaviour
{
	public float pickupRange = 0.1f;
	private GameObject objetInteract;

	[Header("Button List")]
	public string interactButton;


	[Header("Tag List")]
	public string itemTag = "item";

	[Header("Inventory's Datas")]
	public Transform itemPrefab;
	public Transform invertorySlots;
	public int slotsCount = 5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown(1)){
        	objetInteract = collider.gameObject;
        	if (objetInteract.tag == itemTag){
        		//pick up
        		// check if inventory is full
        		if(inventorySlots.childCount == slotsCount){
        			Debug.Log("Inventory is full");
        		}
        		//however
        		else{
        			//make disappear object
        			
        			//integrate new item inventory

        		}
        			
        	}
        }
    }



    void TryToInteract(){




    }
}
