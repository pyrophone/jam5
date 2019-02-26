using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flood : MonoBehaviour {
    
    public float playerSpeedRefactor;

    [SerializeField] private int _floodTime;

    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;

    [SerializeField] private Text timerText;

    private bool _isMoving;

    // Use this for initialization
    void Start() {
        _isMoving = true;
        countDownTime = _floodTime;
        timerText.text = "" + _floodTime;

        StartCoroutine("CountDown");
    }
	
	// Update is called once per frame
	void Update() {
        if (currentTime < _floodTime && _isMoving) {
            Moving();
        }
        else {
            _isMoving = false;
            OnReachTheEnd();
        }
    }

    private float currentTime = 0;
    private void Moving() {
        currentTime += Time.deltaTime;
        transform.position = Vector3.Lerp(_startPoint.position, _endPoint.position, currentTime / _floodTime);
    }

    /// <summary>
    /// When the flood reach the end point, game is over
    /// </summary>
    private void OnReachTheEnd() {
        
    }

    private int countDownTime;
    private IEnumerator CountDown() {
        while (countDownTime >= 0) {
            timerText.text = "" + countDownTime;
            countDownTime--;
            yield return new WaitForSeconds(1);
        }
    }

}
