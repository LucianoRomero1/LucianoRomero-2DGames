using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Parallax : MonoBehaviour
{
    
    [SerializeField] private float speed = 0.0f; //A cada fondo le agrego una speed
    private Rigidbody2D rigidBody;

    //parallaxCut es la medida que yo utilizo para medir cuando el fondo se fue de rango para volverlo a ubicar en esa posicion
    //el 19f lo medí yo con un GameObject vacío de prueba, siempre puede variar ese valor.
    private float parallaxCut = 18.8f;
    private void Awake() {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        this.rigidBody.velocity = new Vector2(speed, 0f);

        float parentPosition = this.transform.parent.transform.position.x;

        
        if(this.transform.position.x - parentPosition >= parallaxCut){
            this.transform.position = new Vector3(parentPosition - parallaxCut, this.transform.position.y, this.transform.position.z);
        }
    }
}
