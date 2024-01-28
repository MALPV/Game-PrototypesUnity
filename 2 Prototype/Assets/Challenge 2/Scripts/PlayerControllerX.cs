using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Time the player must wait before shooting again
    public float timeout = 2.0f;
    private float timeLastShot;
    void start()
    {
        // Initialize to allow first shot
        timeLastShot = -timeout; 
    }

    // Update is called once per frame
    void Update()
    {
        // Check if enough time has passed since the last shot
        if (Time.time - timeLastShot >= timeout)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

                // Update the time of the last shot
                timeLastShot = Time.time; 
            }
        }
    }
}
