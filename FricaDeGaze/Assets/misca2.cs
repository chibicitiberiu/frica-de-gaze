using UnityEngine;
using System.Collections;

public class misca2 : MonoBehaviour {
	
	IEnumerator Start () {
		//yield return new WaitForSeconds (0.2f);
		//float width = camera.pixelWidth;

		Vector3 position = new Vector3(Random.Range(-5.0F, 5.0F), 0, Random.Range(-5.0F, 5.0F));

		Vector3 pointA = transform.position;
		Vector3 pointB = pointA + new Vector3 (0.5f,0,0.5f);
		while (true) {
			yield return StartCoroutine(MoveObject(transform, pointA, position, 1.5f));
			yield return StartCoroutine(MoveObject(transform, position, pointA, 1.5f));
			position = new Vector3(Random.Range(-5.0F, 5.0F), 0, Random.Range(-5.0F, 5.0F));

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
