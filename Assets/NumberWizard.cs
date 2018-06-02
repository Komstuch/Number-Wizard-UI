using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max;
	int min;
	int guess;
	public int maxGuessesAllowed = 10;
	
	public Text onScreenText;
	
	void Start () {
		StartGame();
	}
	
	void StartGame() {
		max = 1000;
		min = 1;
		guess = Random.Range(min, max+1);	
		onScreenText.text = guess.ToString();	
		//max = max + 1;
	}
	
	void NextGuess(){
		//guess = (max + min)/2;
		guess = Random.Range(min, max+1);	
		onScreenText.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed -1;
		if(maxGuessesAllowed<=0){
			Application.LoadLevel("Win");
		}
		
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
}