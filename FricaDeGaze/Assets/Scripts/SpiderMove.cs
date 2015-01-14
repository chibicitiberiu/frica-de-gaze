using UnityEngine;
using System.Collections;

public class SpiderMove : MonoBehaviour {

	public float Speed;

	Vector3 source;
	Vector3 destination;

	Vector3 generaterandom()
	{
		// Generate positions outside box
		float x, z;
		x = Random.Range(-4f, 4f);
		z = -Random.Range(-4f, 4f);

		return new Vector3 (x, .2f, z);
	}

	IEnumerator Start () {


		source = generaterandom ();
		destination = generaterandom ();

		gameObject.transform.forward = destination - source;
		gameObject.transform.position = source;

		yield return null;
	}
	
	// Update is called once per frame
	void Update () 
	{
		gameObject.transform.position += gameObject.transform.forward * Speed;

		if (Mathf.Abs(gameObject.transform.position.x) > 5f 
		    || Mathf.Abs(gameObject.transform.position.y) > 5f
		    || Mathf.Abs(gameObject.transform.position.z) > 5f)
			Destroy (gameObject);
	}
}
