using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour
{
    string ContraseniaCorrecta;
    string ContraseniaUsuario;
    public Text IngresoUsuario;

    void Start()
    {
        ContraseniaCorrecta = "12345";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContrasenia()
    {
        ContraseniaUsuario = IngresoUsuario.text;
        if (ContraseniaUsuario == ContraseniaCorrecta)
        {
            Debug.Log("Bienvenido");
        }
        else
        {
            Debug.Log("Contraseña incorrecta");
        }
    }
}
