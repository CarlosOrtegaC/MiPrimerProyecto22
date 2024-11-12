using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{
    // Start is called before the first frame update 
    void Start()
    {    
       
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento de izquierda a derecha: A: -1, D: 1, <-: -1, ->: 1
        float inputH = Input.GetAxisRaw("Horizontal");
        float inputV = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector3(inputH, inputV, 0) * 6 * Time.deltaTime); 
        //El 5 son las unidades que recorre en 1 seg y que proporciona el Time.deltaTime

    }
}
