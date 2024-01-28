using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;

    private float projectilePositionY = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (gameObject.name.Contains("Food_Steak"))
        {
            transform.position = new Vector3(transform.position.x, projectilePositionY, transform.position.z);
        }
    }
}
