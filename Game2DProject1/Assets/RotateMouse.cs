/*using UnityEngine;
using System.Collections;

public class RotateMouse : MonoBehaviour {
	
	public Transform target;

	public Transform hello;
	
	
	Vector3 lastTargetPosition;
	
	
	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		
		var Camera = target;
		var player = hello;
		//få detta att fungera!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
		Vector3 screenPos = Camera.WorldToScreenPoint(player.position);
		Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		
		int X = (int)mousePosition.x - (int)screenPos.x;
		
		int Y = (int)mousePosition.y - (int)screenPos.y;
		
		var angle = Mathf.Atan2(Y, X);
		
		angle = (float)(angle * (180/3.1415));
		
		transform.Rotate(0, angle, 0);
		
		Debug.Log (angle);
		
		
	}
}
*/