using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Color CambioColor;
    
    void Update()
    {
        //Esto hace que el color que le asignemos a la variable "CambiColor" pase a ser el color del prefab
       GetComponent<MeshRenderer>().material.color = CambioColor;
    }

    private void OnMouseDown()
    {
        //Con esto conseguimos asignarle el material dado en la variable "CambioColor" al background de la camara
        Camera.main.GetComponent<Camera>().backgroundColor = CambioColor;
    }
}
