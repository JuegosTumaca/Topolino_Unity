using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartel : MonoBehaviour
{
    public GameObject cartelesController;
    public string textoCartel;


    private void Start()
    {
        cartelesController = GameObject.Find("Controlador Carteles");
    }

    public void mostrarCartel()
    {  
        cartelesController.GetComponent<cartelesController>().ActivarUI();
        cartelesController.GetComponent<cartelesController>().MostarTexto(textoCartel);
    }
    public void QuitarCartel()
    {
        cartelesController.GetComponent<cartelesController>().DesactivarUI();
    }
}
