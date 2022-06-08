using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kareler : MonoBehaviour
{
    private SpriteRenderer ressam;
    public Material blue,green,orange,red,yellow;
    public AudioSource renkSesi;

    void Start()
    {
        ressam = GetComponent<SpriteRenderer>();
        RenkVer();
        

    }

    

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)) {

            RenkVer();
            renkSesi.Play ();
        
        }
    }
    void RenkVer() {
        int rastgele = Random.Range(1,6);
        
        switch(rastgele){
            case 1:
                ressam.material= yellow;
                break;

            case 2:
                ressam.material= red;
                break;
                
            case 3:
                ressam.material= green;
                break;

            case 4:
                ressam.material= orange;
                break;

            case 5:
                ressam.material= blue;  
                break;

        }
            
    }
}
