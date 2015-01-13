using UnityEngine;
using System.Collections;

public class MisacaPaianjen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		itembounce();
	}

	Vector3 speed = new Vector3(0,0.002f,0);

	bool bouncing = true;


	// Update is called once per frame
	void Update () {
			if (bouncing == true) {
				this.transform.position += speed;
			} else if (bouncing == false) {
				this.transform.position -= speed;
			}

		//bouncing = !bouncing;
	}

	
	IEnumerator itembounce() {
		
		for(int i=0;i>1;i++)
		{
			
		             // yield return new WaitForSeconds(0.002f);
					  //bouncing = !bouncing;
	                  
					  bouncing = !bouncing;
					  yield return new WaitForSeconds(0.002f);
		 }
		
		
		}


}
