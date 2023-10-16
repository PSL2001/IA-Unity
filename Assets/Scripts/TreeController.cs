using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour
{
    //Referencia de la semilla, debe de ser publica para poder referenciarla correctamente
    public GameObject seed;
    //Referencia al item invisible de flor, es la que genera las semillas
    private GameObject flower;
    // Start is called before the first frame update
    void Start()
    {
        //Obtenemos el objeto de flor
        flower = this.transform.GetChild(1).gameObject;

        //Variable de vida
        float vida = Random.Range(5.0f, 20.0f);
        Invoke("Die", vida);

        //Llamamos a la rutina
        StartCoroutine("GenerateSeeds");
    }

    IEnumerator GenerateSeeds()
    {
        //Esperamos 5 segundos
        yield return new WaitForSeconds(5.0f);

        while (true)
        {
            //Creamos un rango aleatoria para la semilla
            float cambioX = Random.Range(-2.0f, 2.0f);
            float cambioZ = Random.Range(-2.0f, 2.0f);
            Vector3 nuevaPos = new Vector3(flower.transform.position.x + cambioX, this.transform.position.y, this.transform.position.z + cambioZ);

            Instantiate(seed, nuevaPos, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
        }
    }

    private void Die() 
    {
        Destroy(this.gameObject);
    }
}
