using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flood : MonoBehaviour {
    
    public float playerSpeedRefactor;

    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _floodTime;

    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;
    
	// Use this for initialization
	void Start() {
		
	}
	
	// Update is called once per frame
	void Update() {
        if (currentTime < _floodTime) {
            Moving();
        }  
    }

    private float currentTime = 0;
    private void Moving() {
        currentTime += Time.deltaTime;
        transform.position = Vector3.Lerp(_startPoint.position, _endPoint.position, currentTime / _floodTime);
    }

}
