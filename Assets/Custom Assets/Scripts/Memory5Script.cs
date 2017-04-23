using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Memory5Script : MonoBehaviour
{
	public Text itemNameText;
	public Text itemDescText;

	//ceiling
	public bool isBurned5;
	public GameObject itemPristine5;
	public GameObject itemPristineHighlight5;
	public GameObject itemBurned5;

	// Use this for initialization
	void Start ()
	{
		itemNameText.text = (" ");
		itemDescText.text = (" ");

		isBurned5 = false;
		itemPristine5.gameObject.SetActive (true);
		itemPristineHighlight5.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnMouseEnter()
	{
		if (isBurned5 == false)
		{
			itemPristine5.gameObject.SetActive (false);
			itemPristineHighlight5.gameObject.SetActive (true);
			itemNameText.text = ("What if all this breaks...");
		}
	}

	void OnMouseExit()
	{
		if (isBurned5 == false)
		{
			itemPristineHighlight5.gameObject.SetActive (false);
			itemPristine5.gameObject.SetActive (true);
			itemNameText.text = (" ");
		}
	}

	void OnMouseDown ()
	{
		if (isBurned5 == false)
		{
			isBurned5 = true;
			itemPristineHighlight5.gameObject.SetActive (false);
			itemBurned5.gameObject.SetActive (true);
			itemNameText.text = (" ");
			StartCoroutine (Memory2 ());
		}
	}

	IEnumerator Memory2 ()
	{
		itemDescText.text = ("What if they finally see what I really am?");
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();
		yield return new WaitForSecondsRealtime (5);
		itemDescText.text = (" ");
	}
}
