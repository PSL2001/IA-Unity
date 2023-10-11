using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    //GameObject contiene todos los componentes de Unity
    public GameObject pelota;

    // Start is called before the first frame update
    void Start()
    {
        //int tiempoGeneracion = Random.Range(0, 10);
        // Generar un numero aleatorio como entero no incluye el ultimo numero. Esto no pasa con float
        //float tiempoGeneracion = Random.Range(0, 10);
        //Invoke("generar", tiempoGeneracion);
        StartCoroutine("pelotas");
    }
    IEnumerator pelotas() 
    {
        int cont = 0;
        while (cont <= 20)
        {
            Debug.Log(cont);
            Instantiate(pelota, new Vector3(Random.Range(-5.0f, 5.0f), 10, Random.Range(-5.0f, 5.0f)), Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            cont++;
        }

        //while (true)
        //{
        //    Instantiate(pelota, new Vector3(0, 10, 0), Quaternion.identity);
        //    yield return new WaitForSeconds(1.0f);
        //    cont++;

        //    if (cont == 20) 
        //    {
        //        break;
        //    }
        //}

    }
    private void generar()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    Instantiate(pelota, new Vector3(i, 10 + j, k), Quaternion.identity);
                }
            }
        }
    }
}
