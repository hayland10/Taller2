using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    //haces que el usuario modifique 
    public int VELOCIDADPERRITA = 5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ejecutando");
    }

    // Update is called once per frame
    void Update()
    {
        //rota el cubo
        //multiplicas por velicidad perrita para que el usuario de unity pueda cambiarlo 
        //multiplica time.deltaTime para standarizar en cualquier maquina vieja o nueva
      transform.Rotate(Vector3.right * VELOCIDADPERRITA * Time.deltaTime);
      ///transform.Rotate(VELOCIDADPERRITA, 0, 0); este es especifico con y,x,z


    }

    
}
