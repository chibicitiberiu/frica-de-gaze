using UnityEngine;
using System.Collections;

public class misca2 : MonoBehaviour {

	public Transform target;
	IEnumerator Start () {
		//yield return new WaitForSeconds (0.2f);
		//float width = camera.pixelWidth;
		Vector3 dis = transform.position - target.position;
		float xpos = Random.Range (-dis.x, dis.x);
		while (xpos+dis.x > target.position.x || xpos+dis.x < -target.position.x ) 
			xpos = Random.Range (-target.position.x, target.position.x);
		float zpos = Random.Range (-target.position.z, target.position.z);
		while (zpos+dis.z > target.position.z) 
			zpos = Random.Range (-target.position.z, target.position.z);

		Vector3 position = new Vector3(xpos, 0, zpos);
		//transform.TransformVector (new Vector3(target.position.x,target.position.y,target.position));

		Vector3 pointA = transform.position;
		//Vector3 pointB = pointA + new Vector3 (0.5f,0,0.5f);
		while (true) {
			yield return StartCoroutine(MoveObject(transform, pointA, position, 1.5f));
			yield return StartCoroutine(MoveObject(transform, position, pointA, 1.5f));
			while (xpos > target.position.x) 
				xpos = Random.Range (-target.position.x, target.position.x);
			while (zpos > target.position.z || zpos< -target.position.z)
			zpos = Random.Range (-target.position.z, target.position.z);
			position.x = xpos;
			position.y = zpos;

		}
	}
	
	IEnumerator MoveObject (Transform thisTransform, Vector3 startPos, Vector3 endPos, float time) {
		float i = 0.0f;
		float rate = 1.0f / time;
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
