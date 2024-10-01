using UnityEngine;
using System.Collections;

public class MovimientoSimple2 : MonoBehaviour
{
    //defino la velocidad
    public float velocidad = 4f;

    void Start()
    {

        
    }
    void Update()
    {
        float horizontalInput =Input.GetAxis("Horizontal");
        float verticalInput =Input.GetAxis("Vertical");
        float velocidadPorTiempo = velocidad*Time.deltaTime;

        Vector3 nuevaPosicion = new Vector3(horizontalInput, verticalInput,0);



        transform.position= transform.position + nuevaPosicion;
        Debug.Log(transform.position);
    }
}