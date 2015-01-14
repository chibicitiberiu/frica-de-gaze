using UnityEngine;
using System.Collections;

public class AddSpider : MonoBehaviour {

	// Use this for initialization
	public GameObject enemy;
	public SpiderMove sc;

	float randomInterval = 5.0f;
	
	IEnumerator Start() 
	{
		while(true)
		{
			yield return new WaitForSeconds(Random.Range(randomInterval, 2 * randomInterval));

			if (randomInterval > .2f)
				randomInterval -= randomInterval / 10;

			Instantiate(enemy);
			
			float scale = Random.Range(.5f / randomInterval, .5f / randomInterval);

			enemy.transform.position = new Vector3(-4, 0, -4);
			enemy.transform.localScale = new Vector3(scale, scale, scale);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
