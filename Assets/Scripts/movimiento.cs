using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public int velocidadAvance = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("MovimientoIniciando");  
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(KeyCode.W)) {
            
            transform.Translate(Vector3.forward * velocidadAvance * Time.deltaTime );
        }

        if (Input.GetKey(KeyCode.S))
        {
            
            transform.Translate(Vector3.back * velocidadAvance * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
           
            transform.Translate(Vector3.right * velocidadAvance * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
         
            transform.Translate(Vector3.left * velocidadAvance * Time.deltaTime);
        }
    }
}
