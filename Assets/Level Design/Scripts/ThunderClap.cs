 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderClap : MonoBehaviour {

	bool canFlicker = true;
	Light myLight = null;
	public AudioClip clip;

	// Use this for initialization
	void Start () {
		myLight = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (Flicker());
	}

	IEnumerator Flicker () {
		if(canFlicker){
			canFlicker = false;
			GetComponent<AudioSource> ().PlayOneShot (clip);
			myLight.enabled = true;
			yield return new WaitForSeconds (Random.Range(0.1f, 0.4f));
			myLight.enabled = false;
			yield return new WaitForSeconds (Random.Range(0.1f, 5));
			canFlicker = true;
		}
	}
}
