using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VTV : MonoBehaviour
{

    public string patente;
    public int modelo; 
    public float kilometrosRecorridos; 
    public int vencimientoVTV; 
    public float hcPPM; 

    int anioActual = 2025; 

    void Start()
    {
       
        if (patente == "")
        {
            Debug.Log("La patente no puede estar vacia");
            Debug.Log("VTV no aprobada");
            return;
        }

       
        if (modelo < 1900 || modelo > anioActual)
        {
            Debug.Log("El modelo debe estar entre 1900 y el año actual");
            Debug.Log("VTV no aprobada");
            return;
        }

        
        if (kilometrosRecorridos < 0)
        {
            Debug.Log("Los kilometros recorridos no pueden ser negativos");
            Debug.Log("VTV no aprobada");
            return;
        }

        
        if (vencimientoVTV >= anioActual || vencimientoVTV <= modelo)
        {
            Debug.Log("El vencimiento tiene que ser menor al año actual y mayor al año de fabricacion");
            Debug.Log("VTV no aprobada");
            return;
        }

        
        if (hcPPM < 5)
        {
            Debug.Log("El valor de HC no puede ser menor a 5");
            Debug.Log("VTV no aprobada");
            return;
        }

        if (hcPPM > 100)
        {
            Debug.Log("HC ppm mayor a 100");
            Debug.Log("VTV no aprobada");
            return;
        }

        
        float aniosUso = anioActual - modelo;
        float promedioKilometros = kilometrosRecorridos / aniosUso;

        if (promedioKilometros < 10000)
        {
            Debug.Log("VTV aprobada por 2 años");
        }
        else
        {
            Debug.Log("VTV aprobada por 1 año");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
