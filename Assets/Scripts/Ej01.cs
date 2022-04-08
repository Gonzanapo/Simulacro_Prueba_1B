using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej01 : MonoBehaviour
{

    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("1.Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.");

        if (num1 == num2)
        {
            Debug.Log("Los numeros son iguales");
        }
        else
        {
            Debug.Log("Los numeros son distintos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
