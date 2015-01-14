using UnityEngine;
using System.Collections;

public class BallCollisionWithSpider : MonoBehaviour {

	public AudioSource SoundToPlay;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name.Contains ("Spider")) 
		{
			Destroy (gameObject);
			Destroy (other.gameObject);

			SoundToPlay.enabled = true;
			SoundToPlay.Play ();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
