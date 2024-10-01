using UnityEngine;
using System.Collections;

public class MovimientoSimple : MonoBehaviour
{
    void Start()
    {
        // Se mueve un solo espacio
        // transform.position= transform.position + new Vector3(1,0,0);
        
    }
    void Update()
    {
        //Se mueve todo el tiempo
        transform.position= transform.position + new Vector3(1,0,0)*Time.deltaTime;
        Debug.Log(transform.position);
    }
}