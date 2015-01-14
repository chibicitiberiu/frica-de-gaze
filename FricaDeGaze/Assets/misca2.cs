using UnityEngine;
using System.Collections;

public class misca2 : MonoBehaviour {

	public Transform target;
	public float RotationSpeed;

	IEnumerator Start () {

		//yield return new WaitForSeconds (0.2f);
		//float width = camera.pixelWidth;
		/*float speed = 1;
		//move towards the center of the world (or where ever you like)
		Vector3 targetPosition = target.position;
		
		Vector3 currentPosition = this.transform.position;
		//first, check to see if we're close enough to the target
		if(Vector3.Distance(currentPosition, targetPosition) > .1f) { 
			Vector3 directionOfTravel = targetPosition - currentPosition;
			//now normalize the direction, since we only want the direction information
			directionOfTravel.Normalize();
			//scale the movement on each axis by the directionOfTravel vector components
			
			this.transform.Translate(
				0,
				(directionOfTravel.y * speed * Time.deltaTime),
				0,
				Space.World);
		}*/
		//transform.RotateAround (target.position, new Vector3 (0, target.position.y, 0), 0);
		//transform.position = new Vector3(target.position.x,0.1f+target.position.y,target.position.z);
		float dis = Vector3.Distance (transform.position, target.position);
		float xpos = Random.Range (-target.position.x, target.position.x);
		//while (xpos > target.position.x) 
			xpos = Random.Range (-target.position.x, target.position.x);
		float zpos = Random.Range (-target.position.z, target.position.z);
		//while (zpos > target.position.z) 
			zpos = Random.Range (-target.position.z, target.position.z);

		Vector3 position = new Vector3(xpos, 0, zpos);
		//transform.TransformVector (new Vector3(target.position.x,target.position.y,target.position));

		Vector3 pointA = transform.position;
		//Vector3 pointB = pointA + new Vector3 (0.5f,0,0.5f);
		while (true) {
			yield return StartCoroutine(MoveObject(transform, pointA, position, 0.1f));
			yield return StartCoroutine(MoveObject(transform, position, pointA, 0.1f));
			//while (xpos > target.position.x) 
				xpos = Random.Range (-target.position.x, target.position.x);
			//while (zpos > target.position.z)
				zpos = Random.Range (-target.position.z, target.position.z);
			position.x = xpos;
			position.z = zpos;

		}
	}
	
	IEnumerator MoveObject (Transform thisTransform, Vector3 startPos, Vector3 endPos, float time) {


		float i = 0.0f;
		float rate = 0.1f / time;
		while (i < 1.0f) {
			i += Time.deltaTime * rate;
			thisTransform.position = Vector3.Lerp(startPos, endPos, i);

			yield return null; 
		}
	}


	// Update is called once per frame
	void Update () {
		}
	
}
