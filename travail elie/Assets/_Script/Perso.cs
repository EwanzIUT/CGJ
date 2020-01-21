using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perso : MonoBehaviour
{
	public float pickupRange = 0.1f;
	private Collider objetInteract;

	[Header("Button List")]
	public string interactButton;


	[Header("Tag List")]
	public string itemTag = "item";

	[Header("Inventory's Datas")]
	public Transform itemPrefab;
	public Transform inventorySlots;
	public int slotsCount = 5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown(interactButton)){
        	objetInteract =  gameObject.GetComponent<Collider>();//collider.gameObject;
        	if (objetInteract.tag == itemTag){
        		//pick up
        		// check if inventory is full
        		if(inventorySlots.childCount == slotsCount){
        			Debug.Log("Inventory is full");
        		}
        		//however
        		else{
        			//make disappear object
        			objetInteract.SetActive(false);
        			//integrate new item inventory
                    Transform newItem;
                    newItem = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity) as Transform;
                    newItem.SetParent(inventorySlots,false);

        		}
        			
        	}
        }
    }



    void TryToInteract(){




    }
}
