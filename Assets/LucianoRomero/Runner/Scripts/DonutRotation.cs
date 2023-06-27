using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutRotation : MonoBehaviour
{
    [SerializeField] private float speedDonut = 1.0f;

    const float FACTOR = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Vector3 rotation = transform.localEulerAngles;
        // rotation.z -= Time.deltaTime * speedDonut;
        // transform.localEulerAngles = rotation;

        //Esta linea es la misma que las 3 que estaban creadas
        transform.localEulerAngles += new Vector3(0, 0, Time.deltaTime * speedDonut * -FACTOR);
    }
}
