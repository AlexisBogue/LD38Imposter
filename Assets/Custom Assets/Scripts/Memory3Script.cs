using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Memory3Script : MonoBehaviour
{
	public Text itemNameText;
	public Text itemDescText;

	//ceiling
	public bool isBurned3;
	public GameObject itemPristine3;
	public GameObject itemPristineHighlight3;
	public GameObject itemBurned3;

	// Use this for initialization
	void Start ()
	{
		itemNameText.text = (" ");
		itemDescText.text = (" ");

		isBurned3 = false;
		itemPristine3.gameObject.SetActive (true);
		itemPristineHighlight3.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnMouseEnter()
	{
		if (isBurned3 == false)
		{
			itemPristine3.gameObject.SetActive (false);
			itemPristineHighlight3.gameObject.SetActive (true);
			itemNameText.text = ("The teachers were too nice to me...");
		}
	}

	void OnMouseExit()
	{
		if (isBurned3 == false)
		{
			itemPristineHighlight3.gameObject.SetActive (false);
			itemPristine3.gameObject.SetActive (true);
			itemNameText.text = (" ");
		}
	}

	void OnMouseDown ()
	{
		if (isBurned3 == false)
		{
			isBurned3 = true;
			itemPristineHighlight3.gameObject.SetActive (false);
			itemBurned3.gameObject.SetActive (true);
			itemNameText.text = (" ");
			StartCoroutine (Memory2 ());
		}
	}

	IEnumerator Memory2 ()
	{
		itemDescText.text = ("They let me get away with a lot. I never should have graduated.");
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();
		yield return new WaitForSecondsRealtime (5);
		itemDescText.text = (" ");
	}
}
