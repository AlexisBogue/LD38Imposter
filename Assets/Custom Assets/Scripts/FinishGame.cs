using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FinishGame : MonoBehaviour
{

	//private bool isBurned1 = GameObject.GetComponent (typeof(bool)) as Memory1Script;
	//private bool isBurned2 = GameObject.GetComponent (typeof(bool)) as Memory2Script;

	public Memory1Script memory1;
	public Memory2Script memory2;
	public Memory3Script memory3;
	public Memory4Script memory4;
	public Memory5Script memory5;
	public Memory6Script memory6;

	public GameObject finalMessage;

	// Use this for initialization
	void Start ()
	{
		finalMessage.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Memory1Script isBurned1 = GetComponent<Memory1Script> ();

		StartCoroutine (FinishedGame ());
	}

	IEnumerator FinishedGame ()
	{
		if (memory1.isBurned1 && memory2.isBurned2 && memory3.isBurned3 && memory4.isBurned4 && memory5.isBurned5 && memory6.isBurned6)
		{
			yield return new WaitForSecondsRealtime (5);
			finalMessage.gameObject.SetActive (true);
		}
	}
}
