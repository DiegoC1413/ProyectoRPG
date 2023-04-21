using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public static int vidaEnemigo = 1;
    
    void Start()
    {
        vidaEnemigo = 1; 
    }

    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D obj) { 
        if (obj.tag == "Player"){
            obj.transform.GetComponentInChildren<VidasPlayer>().TomarDaño(1);
        }
    }

    private void TomarDaño(int daño) {
        vidaEnemigo -= daño;
        if(vidaEnemigo <= 0) {
            Destroy(gameObject);
        }
    
    }
}
