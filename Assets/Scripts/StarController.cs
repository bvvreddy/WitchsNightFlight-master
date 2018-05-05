
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {
	
	[SerializeField]
	private float speed = 5f;
	[SerializeField]
	private float startX;
	[SerializeField]
	private float endX;
	[SerializeField]
	private float bottomY = -298;
	[SerializeField]
	private float topY = 1028;
    
	private Transform _transform;
	private Vector2 _currentPos;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPos = _transform.position;
		Reset();
	}
	
	// Update is called once per frame
	void Update () {
		_currentPos = _transform.position;
        
		_currentPos -= new Vector2(speed, 0);
        
		if(_currentPos.x < endX){
			//reset
			Reset();
		}

		_transform.position = _currentPos;
	}

	public void Reset(){
		float y = Random.Range (bottomY, topY);
		float dx = Random.Range (0, 300);
		_currentPos = new Vector2 (startX + dx, y);
		_transform.position = _currentPos;
	}
}
