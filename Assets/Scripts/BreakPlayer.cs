using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakPlayer : MonoBehaviour
{
    public int vida;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("AttInimigo") || collision.gameObject.tag.Equals("AttBoss"))
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
