using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hintbtnClicked : MonoBehaviour {

	public GameObject hintbg;
	public GameObject hint1;
	public GameObject hint2;
	public GameObject hint3;
	public GameObject hint4;
	public GameObject hint5;
	public GameObject hint6;
	public GameObject hint7;



	// Use this for initialization
	void Start () {
		hintbg.SetActive (false);
		hint1.SetActive (false);
		hint2.SetActive (false);
		hint3.SetActive (false);
		hint4.SetActive (false);
		hint5.SetActive (false);
		hint6.SetActive (false);
		hint7.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			hintbg.SetActive (true);
			hint1.SetActive (true);
			hint2.SetActive (true);
			hint3.SetActive (true);
			hint4.SetActive (true);
			hint5.SetActive (true);
			hint6.SetActive (true);
			hint7.SetActive (true);

		} else if (Input.GetMouseButtonUp (0)) {
			hintbg.SetActive (false);
			hint1.SetActive (false);
			hint2.SetActive (false);
			hint3.SetActive (false);
			hint4.SetActive (false);
			hint5.SetActive (false);
			hint6.SetActive (false);
			hint7.SetActive (false);
		}

	}

}
