using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

		int max = 1000;
		int min = 1;
		int guess;
		public int maxGuessesAllowed;
		public Text text;
		public Text remaining;
	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame(){
		max += 1;
		guess = Random.Range(min, max);
		text.text = guess.ToString();

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			GuessHigher();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)){
			GuessLower();
		}
	}

	public void GuessHigher(){		//This is called when you press the up arrow button
		min = guess;
		NextGuess();
	}

	public void GuessLower(){		//This is called when you press the down arrow button
		max = guess;
		NextGuess();
	}


	void NextGuess(){
		guess = (max + min)/2;
		text.text = guess.ToString();
		maxGuessesAllowed--;
		remaining.text = maxGuessesAllowed.ToString();
		if(maxGuessesAllowed <= 0){
			Application.LoadLevel("Win");		
		}
	}
}
