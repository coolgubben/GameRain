using UnityEngine;
using System.Collections;

public class openParaply : MonoBehaviour {

	public Transform prefab;
	Animator anim;

	void Start()
	{
		anim = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		/*if(Input.GetButton("Fire1")) {
			Destroy(transform.gameObject);
			Instantiate(prefab);
		}*/


		if (Input.GetMouseButtonDown (0)) 
		{

			    anim.SetBool("IsOpen", true);
				Destroy (transform.gameObject);
				Instantiate (prefab);


						
			    //GetComponent<Animation>().Play("Umbrellimation");

		}


		if (Input.GetMouseButtonUp (0)) {

			anim.SetBool("IsOpen", false);
			Destroy (transform.gameObject);
			Instantiate (prefab);

				}

	}
}
