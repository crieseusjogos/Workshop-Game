using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Espinho
/// </summary>
public class Spike : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            //chamamos um metodo de hit do player
            collision.GetComponent<Player>().Hit();
        }
    }
}
