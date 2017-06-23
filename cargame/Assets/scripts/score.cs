using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour { 

	public int score = 0;
	public int highScore = 0;
	string highScoreKey = "HighScore";
	public Text guiText1;

	void Start(){
		//Get the highScore from player prefs if it is there, 0 otherwise.
		highScore = PlayerPrefs.GetInt(highScoreKey,0);    
	}

	void Update(){
		guiText1.text = "Score:" + score.ToString();
	}

	void OnDisable(){

		//If our scoree is greter than highscore, set new higscore and save.
		if(score>highScore){
			PlayerPrefs.SetInt(highScoreKey, score);
			PlayerPrefs.Save();
		}
	}

}