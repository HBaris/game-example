using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kazandın : MonoBehaviour
{
    public SpriteRenderer kare1 , kare2 ;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(kare1.material.name == kare2.material.name){

            Debug.Log("Tebrikssss");
        
        
        }
        
    }
}
