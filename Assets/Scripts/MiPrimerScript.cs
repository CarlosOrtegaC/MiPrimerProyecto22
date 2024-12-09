using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{
    private Vector3 posicionInicial;
    private int score = 0;
    private int vidas = 3;
    [SerializeField] private TextMeshProUGUI textoScore;
    [SerializeField] private TextMeshProUGUI textoVidas;
    [SerializeField] private GameObject buttonRetry;
    // Start is called before the first frame update 
    void Start()
    {
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento de izquierda a derecha: A: -1, D: 1, <-: -1, ->: 1
        float inputH = Input.GetAxisRaw("Horizontal");
        float inputV = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector3(inputH, inputV, 0).normalized * 5 * Time.deltaTime); 
        //El 5 son las unidades que recorre en 1 seg y que proporciona el Time.deltaTime

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Moneda"))
        {
            Destroy(collision.gameObject);
            score++;
            textoScore.text = "Score: " + score;
        }
        else if (collision.gameObject.CompareTag("Trampa"))
        {
            vidas--;
            textoVidas.text = "Vidas: " + vidas;
            if (vidas <= 0)
            {
                Destroy(this.gameObject);
                buttonRetry.SetActive(true);
            }
            else
            { 
                transform.position = posicionInicial;
            }
        }
    }
}
