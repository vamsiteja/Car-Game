using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour {

	public GameObject []cars;
	//public GameObject car;
	int carNo;
	public float maxPos = 2.2f;
	public float delayTimer = 2.0f;

	float timer;

	// Use this for initialization
	void Start () {
		#if UNITY_ANDROID
		delayTimer = 0.8f;
		#endif
		timer = delayTimer;


	}
	
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;

		if (timer <= 0) {
			Vector3 carPos=new Vector3(Random.Range(-2.2f,2.2f),4.5f,0);
			//= new Vector3(Random.Range(-2.2f,2.2f),4.5f,0);
			carNo = Random.Range (0,5);

			int a= Random.Range(0,4);
			switch (a) {
			case 0:
				carPos = new Vector3 (-2.2f, 8.5f,0f);
				break;
			case 1:
				carPos = new Vector3 (-0.9f, 8.5f,0f );
				break;
			case 2: carPos = new Vector3 (1.0f, 8.5f, 0f);
				break;
			case 3:
				carPos = new Vector3 (2.2f, 8.5f, 0f);
				break;

			}
			Instantiate (cars[carNo], carPos, transform.rotation);
			//Instantiate (car, carPos, transform.rotation);
			timer = delayTimer;
			Debug.Log ("call");
		}


	}
}
