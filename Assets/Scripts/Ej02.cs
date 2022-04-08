using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej02 : MonoBehaviour
{


    public float precio1;
    public float precio2;
    public float precio3;
    public float monto_total;
    float restante;
    float costo_productos;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible. Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuánto dinero sobra o falta.");

        costo_productos = precio1 + precio2 + precio3;

        restante = monto_total - costo_productos;

        if(monto_total > costo_productos)
        {
            Debug.Log("El costo de los productos es " +costo_productos+ ", el vuelto es de $"+restante);
        }
        else
        {
            Debug.Log("No tienes suficiente plata. El costo de los productos es "+costo_productos+", te faltan $"+restante);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
