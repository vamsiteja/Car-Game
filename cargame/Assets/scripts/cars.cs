using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cars : MonoBehaviour {
	public float speed=10;
	Vector3 pos;
	public float max=2.2f;
	// Use this for initialization
	public Text scoreText;
	bool gameOver=false;
	int score;
	void Start () {
		
		pos = transform.position;
		transform.Translate (new Vector3 (1.1f, pos.y));
		pos = transform.position;


		gameOver = false;
		score = 0;
		InvokeRepeating ("scoreUpdate", 1.0f, 0.5f);

	}
	
	// Update is called once per frame
	void Update () {
		/*pos.x += Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
		pos.x = Mathf.Clamp (pos.x, -2.2f, 2.2f);*/
		transform.position = pos;

		if (gameOver == false)
			scoreText.text = "Score: " + score;    
		// check ();
		if (PlayerPrefs.GetInt ("high", 0) < score) {
			PlayerPrefs.SetInt ("high", score);
		}

	}

	void scoreUpdate(){
		if (gameOver == false) {
			score += 1;
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Enemy Car") {
			Destroy (gameObject);
			gameOver = true;
			Application.LoadLevel ("game over");
		
		}

	}
	public void left()
	{   pos = transform.position;
		pos.x = pos.x - 1.1f;
		pos.x = Mathf.Clamp (pos.x, -2.1f, 2.1f);
		transform.Translate (pos);

	}
	public void right()
	{   pos = transform.position;
		pos.x = pos.x + 1.1f;
		pos.x = Mathf.Clamp (pos.x, -2.2f, 2.2f);
		transform.Translate (pos);

	}

}
 