using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject prefab;
	public Camera gameCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3(Mathf.PingPong(Time.time * 5, 10), transform.position.y, transform.position.z);

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate (prefab, new Vector3 (transform.position.x, transform.position.y - 2, transform.position.z), Quaternion.identity);

			Vector3 newHeight = transform.position;
			Vector3 newCameraHeight = gameCamera.transform.position;

			newHeight.y += 2;
			newCameraHeight.y += 2;

			transform.position = newHeight;
			gameCamera.transform.position = newCameraHeight;
		}
	}
}
