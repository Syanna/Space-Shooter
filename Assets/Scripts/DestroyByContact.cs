using UnityEngine;
using System.Collections;

public class DestroyByCOntact : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		Destroy (gameObject);
	}
}
