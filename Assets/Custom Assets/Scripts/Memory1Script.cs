using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Memory1Script : MonoBehaviour
{
	public Text itemNameText;
	public Text itemDescText;

	//dresser & picture of friends
	public bool isBurned1;

	public GameObject itemPristine1;
	public GameObject itemPristineHighlight1;
	public GameObject itemBurned1;

	// Use this for initialization
	void Start ()
	{
		itemNameText.text = (" ");
		itemDescText.text = (" ");

		isBurned1 = false;
		itemPristine1.gameObject.SetActive (true);
		itemPristineHighlight1.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnMouseEnter()
	{
		if (isBurned1 == false)
		{
			itemPristine1.gameObject.SetActive (false);
			itemPristineHighlight1.gameObject.SetActive (true);
			itemNameText.text = ("My friends say such nice things...");
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
	}

	IEnumerator Memory1 ()
	{
		itemDescText.text = ("How do I know it's real? Did I trick them?");
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();
		yield return new WaitForSecondsRealtime (5);
		itemDescText.text = (" ");
	}
}
