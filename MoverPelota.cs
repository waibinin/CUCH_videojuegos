using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPelota : MonoBehaviour
{
public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Esto es para ver que tecla tocamos y guardarla en una variable
         float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");



        transform.position= transform.position + new Vector3(horizontalInput,verticalInput,0)*Time.deltaTime;
       // transform.localScale = transform.localScale + new Vector3(1,1,1)*Time.deltaTime;
    }
}
