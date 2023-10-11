using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Este script es un ejemplo basico de movimiento usando como método una fuerza
 * en este caso se utiliza para simular un salto
 */
public class Movement2 : MonoBehaviour
{
    private Vector3 m;
    private Vector3 s;
    private int speed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        m = Vector3.zero;
        s = Vector3.zero;

        if (Input.GetKey(KeyCode.A)) //Izquierda
        {
            m.x = -1;
        }

        if (Input.GetKey(KeyCode.D)) //Derecha
        {
            m.x = 1;
        }

        if (Input.GetKey(KeyCode.W)) //Adelante
        {
            m.z = 1;
        }

        if (Input.GetKey(KeyCode.S)) //Atras
        {
            m.z = -1;
        }
        if (Input.GetKey(KeyCode.Space)) //Espacio
        {
            s.y = 1;
        } 

    }

    private void FixedUpdate()
    {
        if (transform.position.y < 1.5f)
        {
            rb.AddForce(s * 1, ForceMode.Impulse);
        }
        rb.MovePosition(rb.position + m.normalized * speed * Time.fixedDeltaTime);
    }
}
