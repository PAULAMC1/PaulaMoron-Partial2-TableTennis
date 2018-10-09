using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightTab : MonoBehaviour {

    // Use this for initialization
    private void Start () {
		
	}

    // Update is called once per frame
    private void Update () {
		
        //Si se presiona tecla izquierda se mueve a su izquierda
        if(Input.GetKey(KeyCode.LeftArrow)) 
        {
            this.transform.Translate(Vector3.left*1f);
        }

        //Si se presiona tecla derecha se mueve a su derecha
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right*1f);
        }

        //Si se presiona tecla M se mueve atras
        if (Input.GetKey(KeyCode.M))
        {
            this.transform.Translate(Vector3.back * 1f);
        }

        //Si se presiona tecla B se mueve adelante
        if (Input.GetKey(KeyCode.B))
        {
            this.transform.Translate(Vector3.forward * 1f);
        }

        //Si se presiona tecla arriba se mueve arriba
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up*1f);
        }

        //Si se presiona tecla abajo se mueve abajo
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down*1f);
        }

    }
}
