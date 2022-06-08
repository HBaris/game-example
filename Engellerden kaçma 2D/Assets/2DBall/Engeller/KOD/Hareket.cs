using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public float harekethizi;


    // Update is called once per frame
    void Update()
    {
        float hiz = harekethizi = Input.GetAxis("Horizontal");
        transform.Translate (hiz * Time.deltaTime,0,0);
    }
}
