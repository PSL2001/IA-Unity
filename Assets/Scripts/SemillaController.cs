using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemillaController : MonoBehaviour
{
    //La semilla generará un arbol necesito una referencia a este
    public GameObject tree;
    // Start is called before the first frame update
    void Start()
    {
        float tiempoGerminacion = Random.Range(2.0f, 10.0f);
        Invoke("generateTree", tiempoGerminacion);
    }

    private void generateTree()
    {
        Instantiate(tree, new Vector3(this.transform.position.x, 0, this.transform.position.z), Quaternion.identity);
        Destroy(this.gameObject);
    }
}
