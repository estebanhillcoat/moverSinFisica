using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float velocidad = 0.5f;

    void Update()
    {
    
        // Rotando el Objeto
        //cuando toque la tecla D se ejecute el codigo de abajo
        // cuando D ejecutar codigo abajo
        // si (presiono D) { ejecuta codigo abajo }

        if (Input.GetKey(KeyCode.D))

        { transform.Rotate(new Vector3(0, velocidad, 0)); }
        if (Input.GetKey(KeyCode.A))

        { transform.Rotate(new Vector3(0, -velocidad, 0)); }

        // movimiento hacia adelante 

        if (Input.GetKey(KeyCode.W))

        { transform.Translate(new Vector3(velocidad, 0, 0)); }
    }
}
