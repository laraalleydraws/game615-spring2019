using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float moveSpeed;
    private float maxSpeed = 5f;

    private Vector3 input;

    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        input = new Vector3(Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
        if (rigidbody.velocity.magnitude < maxSpeed)
        {
            rigidbody.AddForce(input * moveSpeed);
        }

    }
}