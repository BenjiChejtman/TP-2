using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MariaDeEdad : MonoBehaviour
{
    public int EdadUsuario;
    public Text MiTexto;

    void Start()
    {
        if (EdadUsuario >= 18)
        {
            MiTexto.text = "El usuario es mayor de edad.";
            Debug.Log("El usuario es mayor de edad.");
        }
        else
        {
            MiTexto.text = "El usuario es menor de edad.";
            Debug.Log("El usuario es menor de edad.");  
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
