using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayer : MonoBehaviour {

    [SerializeField] private KeyCode _moveUpKey;
    [SerializeField] private KeyCode _moveDownKey;
    [SerializeField] private KeyCode _moveLeftKey;
    [SerializeField] private KeyCode _moveRightKey;

    public int index;

    private Vector3 _faceDirection;

    [SerializeField] private float _defaultMoveSpeed;
    private float _moveSpeed;

    // Use this for initialization
    void Start () {
        _moveSpeed = _defaultMoveSpeed;
        _faceDirection = transform.right;
    }
	
	// Update is called once per frame
	void Update () {

        float horizontal = Input.GetAxis("Horizontal-" + index);
        float vertical = Input.GetAxis("Vertical-" + index);

        transform.position = new Vector3(transform.position.x + horizontal * Time.deltaTime * _moveSpeed, transform.position.y, transform.position.z + vertical * Time.deltaTime * _moveSpeed);

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
