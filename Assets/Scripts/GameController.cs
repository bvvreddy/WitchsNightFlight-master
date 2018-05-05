/*source:(Witch)1.bp.blogspot.com/-dxo-mpRG9ag/UT10KQmp65l/AAAAAAAAOsc/etpq6_i2has/s1600/fantasy_witch.png*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	[SerializeField]
	Text lblScore;
	[SerializeField]
	Text lblLife;
	[SerializeField]
	Text lblGameOver;
	[SerializeField]
	Text lblHighScore;
	[SerializeField]
	Button btnReset;

	private int _score = 0;
	private int _life = 5;

	public int Score{
		get{ return _score; }
		set{
			_score = value;
			lblScore.text = "Score: " + _score;
		}
	}

	public int Life {
		get{ return _life; }
		set {
			_life = value; 
			if (_life <= 0) {
				//set Game over
				gameOver();
			}else{
				lblLife.text = "Life: " + _life;
			}
		}
	}
		
	private void initialize(){
		Score = 0;
		Life = 5;
       
		lblGameOver.gameObject.SetActive (false);
		lblHighScore.gameObject.SetActive (false);
		btnReset.gameObject.SetActive (false);
		lblScore.gameObject.SetActive(true);
		lblLife.gameObject.SetActive (true);
	}

	private void gameOver(){
		//final score
		lblHighScore.text = "Your score: " + _score;
		lblGameOver.gameObject.SetActive (true);
		lblHighScore.gameObject.SetActive (true);
		btnReset.gameObject.SetActive (true);
		lblScore.gameObject.SetActive(false);
		lblLife.gameObject.SetActive (false);
	
	}

	// Use this for initialization
	void Start () {
		initialize ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//reset button
	public void btnResetClick(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

}
