using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer_Pres : MonoBehaviour
{

    public float TempsRestant = 18.0f;
    public bool fin = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TempsRestant -= Time.deltaTime;
        if(TempsRestant < 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
