using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInimigo : MonoBehaviour
{
    public GameObject spawn;
    public float tempoCria;
    private float tempoFoi;
    public int qtdLimite;
    private int qtdCriada = 0;

    void Update()
    {
        if (qtdLimite > qtdCriada)
        {
            tempoFoi += Time.deltaTime;

            if (tempoFoi > tempoCria)
            {
                GameObject objeto = Instantiate(spawn, transform.position, transform.rotation);
                tempoFoi = 0;
                qtdCriada++;
            }
        }
    }
}
