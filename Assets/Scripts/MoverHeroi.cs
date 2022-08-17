using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverHeroi : MonoBehaviour
{
    public List<Sprite> imgAndarCima;
    public List<Sprite> imgAndarBaixo;
    public SpriteRenderer MostrarImagem;
    public int indice = 0;
    public int contador = 0;
    public string texto = "";

    void Start()
    {
        MostrarImagem = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
    }


    void Movimento()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x - 0.002f, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + 0.002f, transform.position.y, transform.position.z);
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
        
    }
    
}
