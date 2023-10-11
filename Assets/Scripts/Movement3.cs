using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3 : MonoBehaviour
{
    private Vector3 m;
    private CharacterController mController;
    private int speed;
    // Start is called before the first frame update
    void Start()
    {
        mController = this.GetComponent<CharacterController>();
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        m = Vector3.zero;

        if (Input.GetKey(KeyCode.A)) //Izquierda
        {
            m.x = -1;
            //m = Vector3.left;
        }

        if (Input.GetKey(KeyCode.D)) //Derecha
        {
            m.x = 1;
            //m = Vector3.right;
        }

        if (Input.GetKey(KeyCode.W)) //Adelante
        {
            m.z = 1;
            //m = Vector3.forward;
        }

        if (Input.GetKey(KeyCode.S)) //Atras
        {
            m.z = -1;
            //m = Vector3.back;
        }
        mController.SimpleMove(m.normalized * speed);
    }
}
