using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowVehicle : MonoBehaviour
{
    public GameObject vehicle;
    private Vector3 offset = new Vector3(0, 14, -12);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = vehicle.transform.position + offset;
    }
}
