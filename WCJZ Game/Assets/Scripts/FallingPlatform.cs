using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Plataforma que cai
/// </summary>
public class FallingPlatform : MonoBehaviour
{
    public float fallingTime; //tempo de delay para cair

    public BoxCollider2D boxCollider; //referencia do colisor
    public TargetJoint2D joint; //referencia do joint

    //metodo que faz a plataforma cair
    void Falling()
    {
        boxCollider.enabled = false; //desativamos o colisor
        joint.enabled = false; //desativamos o joint
        Destroy(gameObject, 4); //destroi o objeto depois de 4 segundos
    }

    //detecta colisao da plataforma com outro objeto
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //certificamos que o objeto a ser colidido é o player
        if(collision.transform.CompareTag("Player"))
        {
            Invoke("Falling", fallingTime); //chamamos o metodo Falling depois de alguns segundos            
        }
    }
}
