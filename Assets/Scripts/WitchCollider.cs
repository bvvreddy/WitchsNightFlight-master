using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchCollider : MonoBehaviour {
	[SerializeField]
	GameController gameController;

	private AudioSource _starSound;
	private AudioSource _enemySound;

	// Use this for initialization
	void Start () {
		AudioSource[] audioSources = GetComponents<AudioSource> ();
		_starSound = audioSources[0];
		_enemySound = audioSources[1];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag.Equals("star")){
			Debug.Log ("Collision star\n"); 
            
			if (_starSound != null) {
				_starSound.Play ();
			}
            
			other.gameObject.GetComponent<StarController> ().Reset ();
            
			gameController.Score += 100;

		}else if(other.gameObject.tag.Equals("enemy")){
			Debug.Log ("Collision enemy\n");
			if (_enemySound != null) {
				_enemySound.Play ();
			}
            
			other.gameObject.GetComponent<EnemyController> ().Reset ();
            
			gameController.Life -= 1;
		}
			
	}
}
