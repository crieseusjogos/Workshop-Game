using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Trofeu que carrega nova cena
/// </summary>
public class FinalPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            //aqui chama metodo que passa de fase
            SceneManager.LoadScene("Scene2");
        }
    }
}
