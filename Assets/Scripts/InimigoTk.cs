using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoTk : MonoBehaviour
{
    public List<Sprite> imgAndarCima;
    public List<Sprite> imgAndarBaixo;
    public List<Sprite> imgAndarEsquerda;
    public List<Sprite> imgAndarDireita;
    public SpriteRenderer MostrarImagem;
    public int indice = 0;
    public int contador = 0;
    public string texto = "";
    public string destino = "";
    public int posMin;
    public int posMax;
    public int contador2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        MostrarImagem = GetComponent<SpriteRenderer>();
        destino = "Direita";
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
        Inteligencia();
        //InteligenciaRandomica();
    }

    void InteligenciaRandomica()
    {
        contador2 = contador2 + 1;
        if (contador2 > 100)
        {
            contador2 = 0;
            int numeroDestino = Random.Range(0, 4);
            if (numeroDestino == 0)
            {
                destino = "Esquerda";
            }
            if (numeroDestino == 1)
            {
                destino = "Direita";
            }
            if (numeroDestino == 2)
            {
                destino = "Cima";
            }
            if (numeroDestino == 3)
            {
                destino = "Baixo";
            }
        }
    }

    void Inteligencia()
    {
        if (transform.position.x > posMax)
        {
            destino = "Esquerda";
        }
        if (transform.position.x < posMin)
        {
            destino = "Direita";
        }
    }


    void Movimento()
    {
        if (destino == "Esquerda")
        {
            transform.position = new Vector3(transform.position.x - 0.002f, transform.position.y, transform.position.z);
            texto = "Esquerda";
            Animacao();
        }
        if (destino == "Direita")
        {
            transform.position = new Vector3(transform.position.x + 0.002f, transform.position.y, transform.position.z);
            texto = "Direita";
            Animacao();
        }
        if (destino == "Cima")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.002f, transform.position.z);
            texto = "Cima";
            Animacao();
        }
        if (destino == "Baixo")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.002f, transform.position.z);
            texto = "Baixo";
            Animacao();
        }
    }

    void Animacao()
    {
        contador = contador + 1;
        if (contador > 50)
        {
            indice = indice + 1;
            if (indice > 3)
            {
                indice = 0;
            }
            contador = 0;
        }
        if (texto == "Cima")
        {
            MostrarImagem.sprite = imgAndarCima[indice];
        }
        if (texto == "Baixo")
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
