using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour {

	public Text moneyText;

	public int currentGold;

	void Start () {
		PlayerPrefs.SetInt("CurrentMoney",currentGold);
		if (PlayerPrefs.HasKey ("CurrentMoney")) {
			currentGold = PlayerPrefs.GetInt ("CurrentMoney");
		} else {
			currentGold = 0;
			PlayerPrefs.SetInt("CurrentMoney",0);
		}
		moneyText.text = "Euros: " + currentGold;
	}

	void Update () {
		PlayerPrefs.SetInt ("CurrentMoney", currentGold);
		moneyText.text = "Euros: " + currentGold;
	}

	public void AddMoney(int goldToAdd){
		currentGold += goldToAdd;
		PlayerPrefs.SetInt ("CurrentMoney", currentGold);
		moneyText.text = "Euros: " + currentGold;
	}

}
