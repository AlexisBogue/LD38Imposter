using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ItemControllerBackup : MonoBehaviour
{
	public Text itemNameText;
	public Text itemDescText;

	public GameObject finalMessage;

	//dresser & picture of friends
	public bool isBurned1;
	public GameObject itemPristine1;
	public GameObject itemPristineHighlight1;
	public GameObject itemBurned1;

	//ceiling
	public bool isBurned2;
	public GameObject itemPristine2;
	public GameObject itemPristineHighlight2;
	public GameObject itemBurned2;

	// Use this for initialization
	void Start ()
	{
		finalMessage.gameObject.SetActive (false);

		itemNameText.text = (" ");
		itemDescText.text = (" ");

		isBurned1 = false;
		itemPristine1.gameObject.SetActive (true);
		itemPristineHighlight1.gameObject.SetActive (false);

		isBurned2 = false;
		itemPristine2.gameObject.SetActive (true);
		itemPristineHighlight2.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		StartCoroutine (FinishedGame ());
	}

	IEnumerator FinishedGame ()
	{
		if (isBurned1 && isBurned2)
		{
			yield return new WaitForSecondsRealtime (5);
			finalMessage.gameObject.SetActive (true);
		}
	}

	void OnMouseEnter()
	{
		if (isBurned1 == false)
		{
			itemPristine1.gameObject.SetActive (false);
			itemPristineHighlight1.gameObject.SetActive (true);
			itemNameText.text = ("Memory1");
		}

		if (isBurned2 == false)
		{
			itemPristine2.gameObject.SetActive (false);
			itemPristineHighlight2.gameObject.SetActive (true);
			itemNameText.text = ("Sigh...");
		}
	}

	void OnMouseExit()
	{
		if (isBurned1 == false)
		{
			itemPristineHighlight1.gameObject.SetActive (false);
			itemPristine1.gameObject.SetActive (true);
			itemNameText.text = (" ");
		}

		if (isBurned2 == false)
		{
			itemPristineHighlight2.gameObject.SetActive (false);
			itemPristine2.gameObject.SetActive (true);
			itemNameText.text = (" ");
		}
	}

	void OnMouseDown ()
	{
		if (isBurned1 == false)
		{
			isBurned1 = true;
			itemPristineHighlight1.gameObject.SetActive (false);
			itemBurned1.gameObject.SetActive (true);
			itemNameText.text = (" ");
			StartCoroutine (Memory1 ());
		}

		if (isBurned2 == false)
		{
			isBurned2 = true;
			itemPristineHighlight2.gameObject.SetActive (false);
			itemBurned2.gameObject.SetActive (true);
			itemNameText.text = (" ");
			StartCoroutine (Memory2 ());
		}
	}

	IEnumerator Memory1 ()
	{
		itemDescText.text = ("This is a memory");
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();
		yield return new WaitForSecondsRealtime (5);
		itemDescText.text = (" ");
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
