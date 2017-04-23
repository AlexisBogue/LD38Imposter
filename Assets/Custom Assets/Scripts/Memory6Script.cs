using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Memory6Script : MonoBehaviour
{
	public Text itemNameText;
	public Text itemDescText;

	//ceiling
	public bool isBurned6;
	public GameObject itemPristine6;
	public GameObject itemPristineHighlight6;
	public GameObject itemBurned6;

	// Use this for initialization
	void Start ()
	{
		itemNameText.text = (" ");
		itemDescText.text = (" ");

		isBurned6 = false;
		itemPristine6.gameObject.SetActive (true);
		itemPristineHighlight6.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnMouseEnter()
	{
		if (isBurned6 == false)
		{
			itemPristine6.gameObject.SetActive (false);
			itemPristineHighlight6.gameObject.SetActive (true);
			itemNameText.text = ("I wonder which is worse...");
		}
	}

	void OnMouseExit()
	{
		if (isBurned6 == false)
		{
			itemPristineHighlight6.gameObject.SetActive (false);
			itemPristine6.gameObject.SetActive (true);
			itemNameText.text = (" ");
		}
	}

	void OnMouseDown ()
	{
		if (isBurned6 == false)
		{
			isBurned6 = true;
			itemPristineHighlight6.gameObject.SetActive (false);
			itemBurned6.gameObject.SetActive (true);
			itemNameText.text = (" ");
			StartCoroutine (Memory2 ());
		}
	}

	IEnumerator Memory2 ()
	{
		itemDescText.text = ("Invited out of pity, or not invited at all?");
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();
		yield return new WaitForSecondsRealtime (5);
		itemDescText.text = (" ");
	}
}
