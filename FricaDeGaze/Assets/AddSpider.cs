using UnityEngine;
using System.Collections;

public class AddSpider : MonoBehaviour {

	// Use this for initialization
	public GameObject enemy;
	public misca2 sc;
	
	IEnumerator Start() {
		for (int i = 0; i < 10; i++) {
			yield return new WaitForSeconds(Random.Range(0, 5.0f));
			Instantiate(enemy);

			enemy.transform.position = new Vector3(Random.Range(-2.5f, 2.5f),0,Random.Range(-0.5f, 0.5f));
			sc=enemy.AddComponent("misca2") as misca2;

			//sc.Invoke("Start()",0);

		}
	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
