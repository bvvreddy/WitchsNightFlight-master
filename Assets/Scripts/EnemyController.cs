using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	[SerializeField]
	float minXSpeed = 5f;
	[SerializeField]
	float maxXSpeed = 10f;
	[SerializeField]
	float minYSpeed = -2f;
	[SerializeField]
	float maxYSpeed = 2f;
	[SerializeField]
	float bottomYRange = -136; 
	[SerializeField]
	float topYRange = 874; 
	[SerializeField]
	float frequency = -1344;

	private Transform _transform;
	private Vector2 _currentSpeed;
	private Vector2 _currentPos;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		Reset();
	}

	public void Reset(){
		float ySpeed = Random.Range (minYSpeed, maxYSpeed);
		float xSpeed = Random.Range (minXSpeed, maxXSpeed);

		_currentSpeed = new Vector2 (xSpeed, ySpeed);

		float y = Random.Range (bottomYRange, topYRange);
		_transform.position = new Vector2 (1356 + Random.Range (0, 100), y);

	}

	// Update is called once per frame
	void Update () {
		_currentPos = _transform.position;
		_currentPos -= _currentSpeed;
		_transform.position = _currentPos;

		if (_currentPos.x <= frequency) {
			Reset ();
		}
	}
}
