using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMotion : MonoBehaviour {

    // Use this for initialization
    private void Start () {
		
	}

    // Update is called once per frame
    private void Update () {

        // Asi movemos un objeto
       // Si presionamos la techa zquierda, muevo el cilindro hacia izquierda
       if(Input.GetKey(KeyCode.LeftArrow)) 
        {
            this.transform.Translate(Vector3.left);
        }

        // Si preciomo la techa derecha, muevo el cilindro hacia derecha
        if(Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right);
        }
      
        // Si preciomo la techa arriba, muevo el cilindro hacia arriba
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up);
        }

        // Si preciomo la techa abajo, muevo el cilindro hacia abajo
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down);
        }
       
        // Si preciono la tecla Y, rota en eje Y
        if (Input.GetKey(KeyCode.Y)) {
            this.transform.Rotate(Vector3.up);
        }

        // Si preciono la tecla X, rota en eje X
        if (Input.GetKey(KeyCode.Mouse0))
        {
            this.transform.Rotate(Vector3.right);
        }

        // Si preciono la tecla Z, rota en eje Z
        if (Input.GetKey(KeyCode.Mouse1))
        {
            this.transform.Rotate(Vector3.forward);
        }

	}
}
