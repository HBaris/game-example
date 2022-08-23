using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engellere : MonoBehaviour
{
    
  
    void OnCollisionEnter2D(Collision2D temas)
    {
        float xPozisyonu = Random.Range(-5f,5f);
        if (temas.gameObject.tag == "Zemin"){

            transform.position = new Vector2();
        }
    }

    
}
