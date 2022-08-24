using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoEsqueleto : MonoBehaviour
{

    public GameObject Heroi;
    


    void Start()
    {
        Heroi = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        Perseguir();
    }

    void Perseguir()
    {
        float distancia = Vector3.Distance(transform.position, Heroi.transform.position);
        if(distancia < 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, Heroi.transform.position, 0.0005f);

        }

    }


}
