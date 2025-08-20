using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakInimigo : MonoBehaviour
{
    public int vida;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("AttPlayer"))
        {
            vida--;
            Destroy(collision.gameObject);
            if (vida < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
