using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Memory2Script : MonoBehaviour
{
	public Text itemNameText;
	public Text itemDescText;

	//ceiling
	public bool isBurned2;
	public GameObject itemPristine2;
	public GameObject itemPristineHighlight2;
	public GameObject itemBurned2;

	// Use this for initialization
	void Start ()
	{
		itemNameText.text = (" ");
		itemDescText.text = (" ");

		isBurned2 = false;
		itemPristine2.gameObject.SetActive (true);
		itemPristineHighlight2.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnMouseEnter()
	{
		if (isBurned2 == false)
		{
			itemPristine2.gameObject.SetActive (false);
			itemPristineHighlight2.gameObject.SetActive (true);
			itemNameText.text = ("Sigh...");
		}
	}

	void OnMouseExit()
	{
		if (isBurned2 == false)
		{
			itemPristineHighlight2.gameObject.SetActive (false);
			itemPristine2.gameObject.SetActive (true);
			itemNameText.text = (" ");
		}
	}

	void OnMouseDown ()
	{
		if (isBurned2 == false)
		{
			isBurned2 = true;
			itemPristineHighlight2.gameObject.SetActive (false);
			itemBurned2.gameObject.SetActive (true);
			itemNameText.text = (" ");
			StartCoroutine (Memory2 ());
		}
	}

	IEnumerator Memory2 ()
	{
		itemDescText.text = ("What am I even doing?");
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();
		yield return new WaitForSecondsRealtime (5);
		itemDescText.text = (" ");
	}
}
