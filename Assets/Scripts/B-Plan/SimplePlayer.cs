using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayer : MonoBehaviour {

    //[SerializeField] private KeyCode _moveUpKey;
    //[SerializeField] private KeyCode _moveDownKey;
    //[SerializeField] private KeyCode _moveLeftKey;
    //[SerializeField] private KeyCode _moveRightKey;

    public int index;

    [SerializeField] private float maxSpeed;
    [SerializeField] private float minSpeed;
    private Vector3 _faceDirection;

    [SerializeField] private float _defaultMoveSpeed;
    private float _moveSpeed;
    private Rigidbody rb;

    // Use this for initialization
    void Start () {
        _moveSpeed = _defaultMoveSpeed;
        _faceDirection = transform.right;
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        float horizontal = Input.GetAxis("Horizontal-" + index);
        float vertical = Input.GetAxis("Vertical-" + index);

        if (rb.velocity.x < maxSpeed && rb.velocity.x > minSpeed)
        {
            rb.AddForce(horizontal * new Vector3(1, 0, 0) * _moveSpeed * 10);
        }
        else {
            if (rb.velocity.x * horizontal < 0) {
                rb.AddForce(horizontal * new Vector3(1, 0, 0) * _moveSpeed * 50);
            }
        }
        if (rb.velocity.y < maxSpeed && rb.velocity.y > minSpeed)
        {
            rb.AddForce(vertical * new Vector3(0, 0, 1) * _moveSpeed);
        }
        else
        {
            if (rb.velocity.y * vertical < 0)
            {
                rb.AddForce(vertical * new Vector3(0, 0, 1) * _moveSpeed * 50);
            }
        }
        //transform.position = new Vector3(transform.position.x + horizontal * Time.deltaTime * _moveSpeed, transform.position.y, transform.position.z + vertical * Time.deltaTime * _moveSpeed);

        if (horizontal != 0 || vertical != 0) {
            transform.forward = new Vector3(vertical, 0, -horizontal);
        }
    }

    public void MultiplySpeed(float refactor) {
        _moveSpeed = _defaultMoveSpeed * refactor;
    }

    public void ResetSpeed() {
        _moveSpeed = _defaultMoveSpeed;
    }

    private void SetFacing(float rotationY) {
        transform.eulerAngles = new Vector3(0, rotationY, 0);
    }

}
