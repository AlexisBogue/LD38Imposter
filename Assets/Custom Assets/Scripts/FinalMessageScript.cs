using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FinalMessageScript : MonoBehaviour
{

	public Text messageText;
	public GameObject blackScreen;

	public GameObject candle;
	public GameObject candleHighlight;

	private bool gameEnd = false;

	// Use this for initialization
	void Start ()
	{
		blackScreen.gameObject.SetActive (false);
		candleHighlight.gameObject.SetActive (false);
	}

	void OnMouseEnter()
	{
		if (gameEnd == false)
		{
			messageText.text = ("These Are Lies");
			candle.gameObject.SetActive (false);
			candleHighlight.gameObject.SetActive (true);
		}
	}

	void OnMouseExit()
	{
		if (gameEnd == false)
		{
			messageText.text = (" ");
			candleHighlight.gameObject.SetActive (false);
			candle.gameObject.SetActive (true);
		}
	}

	void OnMouseDown()
	{
		gameEnd = true;
		blackScreen.gameObject.SetActive (true);
		messageText.text = ("Be Kind to Yourself. Thank you for playing.");
	}
}
