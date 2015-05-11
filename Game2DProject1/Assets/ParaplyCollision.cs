using UnityEngine;
using System.Collections;

public class ParaplyCollision : MonoBehaviour {

	void Update () {

		Physics2D.IgnoreLayerCollision (8, 9);
	
	}
}