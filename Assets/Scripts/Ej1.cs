using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Todos los ingresos se hacen por Inspector.
//Ingresar:
//nombre de alumno
//de qué año es(un número del 1 al 5)
//a qué orientación pertenece(sólo se puede ingresar la inicial en mayúscula de la especialidad:
//    T para TIC, D para Diseño, G para Gestión, M para Medios y H para Humanidades).
//El programa debe cumplir los siguientes requerimientos:
//Mostrar un mensaje de error si el nombre ingresado es una cadena de caracteres vacía y
//    si el año ingresado no está en el rango del 1 al 5. 
//Si se ingresa un valor diferente a las opciones válidas en el campo ingreso de orientación 
//    escribir en consola “Solo puede ingresar T, D, G, M o H”. 

//Si el año ingresado no está entre 3 y 5 se debe mostrar el mensaje “Error.Aún estás en el ciclo básico”.

//Si los ingresos de nombre, año y orientación son válidos escribir en consola un mensaje de
//    agradecimiento en el siguiente formato: “Muchas gracias[nombreAlumno]!”

public class Ej1 : MonoBehaviour
{
    public string nombrealumno;
    public int año;
    public string orientacion;
    // Start is called before the first frame update
    void Start()
    {
        string tic = T ;
        string diseño = D ;
        string gestion = G ; 
        string medios = M ;
        string humanidades = H ;
        
        if ((nombrealumno.Length ==0 ))
            Debug.Log("Error, no ingresaste tu nombre");

        else if (año > 5 && año < 1)
            Debug.Log("Error, el año que ingresaste no es valido");

        else if (orientacion != tic && orientacion != diseño && orientacion != gestion && orientacion != medios && orientacion != humanidades)
            Debug.Log("Solo se puede ingresar T, D, G, M, H");

        else if (año > 5 && año < 3)
            Debug.Log("Aun no estas en el ciclo basico");

        else
                Debug.Log("Muchas gracias " + nombrealumno);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
