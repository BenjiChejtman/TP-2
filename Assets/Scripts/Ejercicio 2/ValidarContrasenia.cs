using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour
{
    string ContraseniaCorrecta;
    string ContraseniaUsuario;
    public Text IngresoUsuario;
    public Text textoMsj;
    public GameObject cartelitoMsj;
    void Start()
    {
        ContraseniaCorrecta = "12345";
        cartelitoMsj.SetActive(false);
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
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Contraseña inocrrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
