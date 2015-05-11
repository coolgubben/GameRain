using UnityEngine;
using System.Collections;

public class MoveTowardsMouse : MonoBehaviour {
	public Transform startMarker;
	//public Transform endMarker;
	public float speed = 1.0F;
	private float startTime;
	private float journeyLength;
	public Transform target;
	public float smooth = 5.0F;
	void Start() {

	}
	void Update() {
		startTime = Time.time;
		Vector2 relmousepos = Camera.main.ScreenToViewportPoint(Input.mousePosition);        //Mouse position
		Vector3 relobjpos = Camera.main.WorldToViewportPoint (startMarker.position);	//Object position on screen

		Debug.Log (startMarker.position.x);
		//Vector2 relobjpos = new Vector2(objpos.x - 0.5f,objpos.y - 0.5f);           //Set coordinates relative to object
		//Vector2 relmousepos = new Vector2 (mouse.x - 0.5f,mouse.y - 0.5f) - relobjpos;


		journeyLength = Vector3.Distance(relobjpos, relmousepos);
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		transform.position = Vector3.Lerp(relobjpos, relmousepos, fracJourney);
	}
}