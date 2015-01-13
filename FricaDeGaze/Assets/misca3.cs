using UnityEngine;
using System.Collections;

public class misca3 : MonoBehaviour {
	
	
	
	IEnumerator Start () {
		yield return new WaitForSeconds (0.5f);
		Vector3 pointA = transform.position;
		Vector3 pointB = pointA + new Vector3 (0,0.05f,0);
		while (true) {
			yield return StartCoroutine(MoveObject(transform, pointA, pointB, 0.5f));
			yield return StartCoroutine(MoveObject(transform, pointB, pointA, 0.5f));
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
