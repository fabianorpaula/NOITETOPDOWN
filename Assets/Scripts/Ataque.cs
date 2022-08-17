using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{
    //Outro Objeto do Jogo (Game)
    public GameObject MeuInimigo1;

    
    void Update()
    {
        //Minha Posição
        Vector3 minhaPosicao = transform.position;
        Vector3 inimigoPosicao = MeuInimigo1.transform.position;
        float distanciaDoInimigo = Vector3.Distance(minhaPosicao, inimigoPosicao);
        if(distanciaDoInimigo < 2 && Input.GetKeyDown(KeyCode.Z))
        {
            
                Destroy(MeuInimigo1.gameObject);
            
        }
    }
}
