using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    private Rigidbody playerRB;

    private float verticalInput;
    private float horizontalInput;

    public GameObject projectilePrefabs;

    public float speed = 10f;
    public float turnSpeed = 30f;
    public float jumpForce = 20f;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        //DesactiveRotation();
    }

    // Update is called once per frame
    void Update()
    {
        MoveTypeOne();

        Jump();

        Shoot();
    }

    private void MoveTypeOne()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }

    private void MoveTypeTwo()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        playerRB.AddForce(Vector3.forward * verticalInput * speed);
        playerRB.AddForce(Vector3.right * horizontalInput * speed);
    }

    private void DesactiveRotation()
    {
        playerRB.freezeRotation = true;
    }

    private void MoveTypeThree()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3(horizontalInput, 0.0f, verticalInput);

        playerRB.AddForce(move * speed);
    }

    private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(projectilePrefabs, transform.position, projectilePrefabs.transform.rotation);
        }
    }
}
