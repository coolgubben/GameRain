using UnityEngine;
using System.Collections;

public class ParaplyCollision : MonoBehaviour {

	public Transform body;
	public Transform paraply;
	void Start() {
		Physics2D.IgnoreCollision(paraply.collider2D, collider2D);
	}
}