using UnityEngine;
using System.Collections;

public class openParaply : MonoBehaviour {

	public Transform prefab;
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButton("Fire1")) {
			Destroy(transform.gameObject);
			Instantiate(prefab);
		}
	}
}
