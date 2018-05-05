
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchController : MonoBehaviour {
	[SerializeField]
	private float speed = 7f;
	[SerializeField]
	private float topY;
	[SerializeField]
	private float bottomY;

	private Transform _transform;
	private Vector2 _currentPos;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPos = _transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//get current position
		_currentPos = _transform.position;

		float userInput = Input.GetAxis ("Vertical");
        
		if(userInput>0){
			_currentPos += new Vector2 (0, speed);
		}
		if(userInput<0){
			_currentPos -= new Vector2 (0, speed);
		}

		CheckBounds ();

		_transform.position = _currentPos;
	}
    
	private void CheckBounds(){
		if (_currentPos.y > topY) {
			_currentPos.y = topY;
		}
		if (_currentPos.y < bottomY) {
			_currentPos.y = bottomY;
		}
	}
}
