using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovimentoPlayer : MonoBehaviour
{
    public float velocidade = 7;
    private SpriteRenderer flip;

    // Movimento do Clóvis

    void Awake()
    {
        flip = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Horizontal, Movimento
        transform.Translate(
            Input.GetAxis("Horizontal")
            * velocidade
            * Time.deltaTime, 0, 0,
            Space.World
        );

        // Horizontal, Virar
        /*
        if(Input.mousePosition += ?)
        {
            flip.enabled = true;
        }
        else
        {
            flip.enabled = false;
        }
        */


        transform.Translate(0, 
            Input.GetAxis("Vertical")
            * velocidade
            * Time.deltaTime, 0,
            Space.World
        );
    }


}
