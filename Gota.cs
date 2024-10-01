using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gota : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale =  transform.localScale - Vector3.one*Time.deltaTime;
        if(transform.localScale.x<0.0001f)
        {
            Destroy(gameObject);
        }
    }
}
