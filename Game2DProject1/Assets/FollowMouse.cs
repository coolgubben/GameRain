using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour {
	public Transform Player;

	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
		if (Player.FindChild ("2D Character")) {
				
						Debug.Log ("found");
		
				} 
		else {
			Debug.Log ("not found");
		}

		Vector3 objpos = Player.position; //Object position on screen

		Vector2 relobjpos = new Vector2(objpos.x,objpos.y);

		Debug.Log ("relpos x" + relobjpos.x);
		Debug.Log ("relpos y" + relobjpos.y);

		Vector2 mouse = Camera.main.ScreenToViewportPoint(Input.mousePosition); 

		Vector2 relmousepos = new Vector2 ((mouse.x - 0.5f) * 2,(mouse.y - 0.5f) * 2) + relobjpos;

		Debug.Log ("mouse x " + relmousepos.x);
		Debug.Log ("mouse y " + relmousepos.y);

		transform.position = Vector3.Lerp (relobjpos, relmousepos, 10);
	}
}
