using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverHeroi : MonoBehaviour
{
    //Listas de Andar
    public List<Sprite> imgAndarCima;
    public List<Sprite> imgAndarBaixo;
    public List<Sprite> imgAndarEsquerda;
    public List<Sprite> imgAndarDireita;
    public SpriteRenderer MostrarImagem;
    public int indice = 0;
    public int contador = 0;
    public string texto = "";

    //Listas de Ataque
    public List<Sprite> imgAtkEsquerda;
    public List<Sprite> imgAtkDireita;
    public int indiceAtk = 0;
    public int contadorAtk = 0;
    public bool atacou = false;


   
    public List<GameObject> Inimigos;
    
    

    void Start()
    {
        MostrarImagem = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(atacou == true)
        {
            Ataque();
        }
        else
        {
            Movimento();
            if (Input.GetMouseButtonDown(0))
            {
                atacou = true;
            }
        }
        
        
        
    }

    void Ataque()
    {


        if(atacou == true)
        {
            AnimacaoAtaque();
        }
    }


    void AnimacaoAtaque()
    {
        if (texto == "Esquerda")
        {


            MostrarImagem.sprite = imgAtkEsquerda[indiceAtk];
            contadorAtk++;
            if (contadorAtk > 30)
            {
                indiceAtk++;
                contadorAtk = 0;
            }
            if (indiceAtk >= imgAtkEsquerda.Count)
            {
                //Meu ataque terminou
                atacou = false;
                contadorAtk = 0;
                indiceAtk = 0;
                Animacao();

            }
        }
        else if (texto == "Direita")
        {


            MostrarImagem.sprite = imgAtkDireita[indiceAtk];
            contadorAtk++;
            if (contadorAtk > 30)
            {
                indiceAtk++;
                contadorAtk = 0;
            }
            if (indiceAtk >= imgAtkDireita.Count)
            {
                //Meu ataque terminou
                atacou = false;
                contadorAtk = 0;
                indiceAtk = 0;
                Animacao();

            }
        }
        else
        {
            atacou = false;
        }
       

    }

    void Movimento()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x - 0.002f, transform.position.y, transform.position.z);
            texto = "Esquerda";
            Animacao();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + 0.002f, transform.position.y, transform.position.z);
            texto = "Direita";
            Animacao();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y+0.002f, transform.position.z);
            texto = "Cima";
            Animacao();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y-0.002f, transform.position.z);
            texto = "Baixo";
            Animacao();
        }
    }

    void Animacao()
    {
        contador = contador + 1;
        if(contador > 50)
        {
            indice = indice + 1;
            if(indice > 4)
            {
                indice = 0;
            }
            contador = 0;
        }
        if(texto == "Cima")
        {
            MostrarImagem.sprite = imgAndarCima[indice];
        }
        if(texto == "Baixo")
        {
            MostrarImagem.sprite = imgAndarBaixo[indice];
        }
        if (texto == "Esquerda")
        {
            MostrarImagem.sprite = imgAndarEsquerda[indice];
        }
        if (texto == "Direita")
        {
            MostrarImagem.sprite = imgAndarDireita[indice];
        }

    }
    
}
