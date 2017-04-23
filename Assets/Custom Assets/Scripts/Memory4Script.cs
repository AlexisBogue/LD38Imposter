using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Memory4Script : MonoBehaviour
{
	public Text itemNameText;
	public Text itemDescText;

	//ceiling
	public bool isBurned4;
	public GameObject itemPristine4;
	public GameObject itemPristineHighlight4;
	public GameObject itemBurned4;

	// Use this for initialization
	void Start ()
	{
		itemNameText.text = (" ");
		itemDescText.text = (" ");

		isBurned4 = false;
		itemPristine4.gameObject.SetActive (true);
		itemPristineHighlight4.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnMouseEnter()
	{
		if (isBurned4 == false)
		{
			itemPristine4.gameObject.SetActive (false);
			itemPristineHighlight4.gameObject.SetActive (true);
			itemNameText.text = ("For excellence and dedication...");
		}
	}

	void OnMouseExit()
	{
		if (isBurned4 == false)
		{
			itemPristineHighlight4.gameObject.SetActive (false);
			itemPristine4.gameObject.SetActive (true);
			itemNameText.text = (" ");
		}
	}

	void OnMouseDown ()
	{
		if (isBurned4 == false)
		{
			isBurned4 = true;
			itemPristineHighlight4.gameObject.SetActive (false);
			itemBurned4.gameObject.SetActive (true);
			itemNameText.text = (" ");
			StartCoroutine (Memory2 ());
		}
	}

	IEnumerator Memory2 ()
	{
		itemDescText.text = ("How do they not realize I have no idea what I'm doing?");
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();
		yield return new WaitForSecondsRealtime (5);
		itemDescText.text = (" ");
	}
}
