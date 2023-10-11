using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Esta clase muestra el movimiento basico de un objeto usando "Transform"
 */
public class Movement1 : MonoBehaviour
{
    private int speed;
    private int rotationSpeed;
    //Referencia al Animator para el oso. Para controlar que animacion poner
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //Velocidad de movimiento
        speed = 5;
        //Velocidad de rotacion
        rotationSpeed = 72;
        // A no ser que sea transform nunca olvides de utilizar GetComponent!
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movement será 1,0 o -1 dependiendo si queremos que se quede parado(0), se mueve hacia delate(1) o detras(1)
        int movement = 0;
        //Rotation sigue la misma logica de numeros, dependiendo si queremos ir a la derecha (1), no rotar(0) o rotar a la izquierda (-1)
        int rotation = 0;

        if (Input.GetKey(KeyCode.A)) //Izquierda
        {
           rotation = -1;
        }

        if (Input.GetKey(KeyCode.D)) //Derecha
        {
            rotation = 1;
        }

        if (Input.GetKey(KeyCode.W)) //Adelante
        {
            movement = 1;
        }

        if (Input.GetKey(KeyCode.S)) //Atras
        {
           movement = -1;
        }
        // Esto causa que el oso utilize la animacion siempre que este moviendose o este rotando
        if (movement != 0 || rotation != 0)
        {
            animator.SetFloat("Velocidad", 1);
        } else
        {
            animator.SetFloat("Velocidad", 0);
        }
        //Aplicamos movimiento
        this.transform.position = this.transform.position + this.transform.forward * movement * speed * Time.deltaTime;
        //Aplicamos la rotacion
        this.transform.Rotate(this.transform.up, rotation * rotationSpeed * Time.deltaTime);
    }
}
