using UnityEngine;
using System.Collections;

public class BallShoot : MonoBehaviour {

	public GameObject Ball;
	public float ThrowSpeed = 10f;
	public AudioSource ThrowSound;

	private float LastThrowTime = 0;

	// Use this for initialization
	void Start () {
		
		Physics.gravity = new Vector3(0, -20, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
		var direction = Camera.main.transform.forward;

		if (Input.GetButton ("Fire1") && LastThrowTime + .05 < Time.timeSinceLevelLoad) 
		{
			// Throw ball
			var ball = Instantiate(Ball) as GameObject;
			ball.transform.position = Camera.main.transform.position + direction;
			ball.rigidbody.AddForce(direction * ThrowSpeed, ForceMode.Impulse);

			LastThrowTime = Time.timeSinceLevelLoad;

			// Play sound
			if (ThrowSound != null)
				ThrowSound.Play();
		}

	}
}
