using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Maça coletavel
/// </summary>
public class Apple : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            //vamos add 1 maca ao inventario e destruiremos este objeto
            collision.GetComponent<Player>().IncreaseScore();
            Destroy(gameObject);
        }
    }
}
