using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakOnTime : MonoBehaviour
{
    public float tempoLimite;
    private float tempoFoi;

    void Update()
    {
        tempoFoi += Time.deltaTime;
        if (tempoLimite < tempoFoi)
        {
            Destroy(gameObject);
        }
    }
}
