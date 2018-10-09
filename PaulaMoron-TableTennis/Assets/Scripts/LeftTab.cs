using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftTab : MonoBehaviour {

    // Use this for initialization
    private void Start () {
		
	}

    // Update is called once per frame
    private void Update () {
		
        //Si se presiona tecla A se mueve a su izquierda
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left*1f);
        }

        //Si se presiona tecla D se mueve a su izquierda
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right*1f);
        }
        //Si se presiona tecla z se mueve para atras
        if (Input.GetKey(KeyCode.Z))
        {
            this.transform.Translate(Vector3.back * 1f);
        }

        //Si se presiona tecla X se mueve a adelante
        if (Input.GetKey(KeyCode.X))
        {
            this.transform.Translate(Vector3.forward * 1f);
        }

        //Si se presiona tecla W se mueve arriba
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.up*1f);
        }

        //Si se presiona tecla S se mueve abajo
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.down*1f);
        }

	}
}
