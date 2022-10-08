using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Gerenciador de mecanicas gerais.
/// </summary>
public class GameManager : MonoBehaviour
{
    public Transform point;

    //reposiciona o player na posicao do point do GameManager toda vez que inicia o game
    void Start()
    {
        FindObjectOfType<Player>().transform.position = point.position;
    }

}
