using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    // Variables privadas
    private float speed = 20.0f;
    private float turnSpeed = 30.0f;

    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        // Este método se llama una vez al inicio o activación del objeto.
        // Aquí es donde se realizan configuraciones iniciales y preparativos.

        // Por ejemplo, podrías inicializar variables, configurar propiedades,
        // cargar recursos, establecer relaciones entre objetos, etc.
    }

    // Update is called once per frame
    void Update()
    {
        // Este método se llama en cada cuadro renderizado.
        // Aquí es donde se maneja la lógica que necesita actualizarse constantemente.

        // Por ejemplo, podrías actualizar la posición de un objeto en función del tiempo,
        // realizar detecciones de colisiones, procesar la entrada del jugador, etc.

        // ***************************************************************************************

        // Moviendo el vehiculo hacia adelante

        // transform.Translate(0, 0, 1); 
        // transform.Translate(Vector3.forward);

        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // ***************************************************************************************

        // Moviendo el vehiculo horizontalmente

        horizontalInput = Input.GetAxis("Horizontal");

        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
