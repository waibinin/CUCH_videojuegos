using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pincel : MonoBehaviour
{
    public GameObject gota;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        //if(Input.GetMouseButtonDown(0))
        if(Input.GetMouseButton(0))
        {
             Vector3 mousePosition = Input.mousePosition;
             mousePosition.z = 2.0f;
             Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
             Instantiate(gota,objectPosition,Quaternion.identity);
        }
       
    }
}
