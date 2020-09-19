using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour{

		public int currentPoint;
		
		float currentTime = 0f;
		float startingTime = 10f;
		float addedTime = 0f;

		public Text countdownText;
		public Text pointText;

		void Start(){
				currentTime = startingTime;
		}
		public void StartLevel(){
			Application.LoadLevel (1);
		}
		void Update () {
				currentTime -= 1 * Time.deltaTime - addedTime;
				addedTime = 0;
				pointText.text = currentPoint.ToString();
				
				countdownText.text =  currentTime.ToString("0");
				if (currentTime <= 0){
						countdownText.text = "Game Over";// GameOver
						StartLevel();
				}
		}

		public void PickupItem(GameObject obj){
				if (obj.tag == "point"){
						currentPoint++;
				}
				else if (obj.tag == "mask"){
						addedTime = 2f;
				}
				else if (obj.tag == "obstacle"){
						countdownText.text = "Game Over";// GameOver
						Application.Quit();
				}
		}

}
