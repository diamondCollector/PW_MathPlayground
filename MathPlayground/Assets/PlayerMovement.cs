using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] float _rotationSpeed;

    float _horizontalInput;
    float _verticalInput;
    Rigidbody rb;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(0, _horizontalInput * _rotationSpeed * Time.deltaTime, 0);
    }

    private void FixedUpdate()
    {
        rb.position = rb.position + transform.forward * _verticalInput * _speed * Time.deltaTime;
        //rb.MovePosition(rb.position + Vector3.forward * _verticalInput * _speed); 
    }
}
