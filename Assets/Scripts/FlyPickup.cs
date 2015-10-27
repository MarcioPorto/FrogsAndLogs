using UnityEngine;
using System.Collections;

public class FlyPickup : MonoBehaviour {

	[SerializeField]
	private GameObject pickupPrefab;

	void OnTriggerEnter (Collider other) {

		// If the collider other is tagged with "Player"...
		if (other.CompareTag("Player")) {

			// ...add the pickup particles
			// Quartertion.identity = no rotation
			Instantiate(pickupPrefab, transform.position, Quaternion.identity);

			// ...decrement the total number of flies
			FlySpawner.totalFlies--;

			// ...update the score
			ScoreCounter.score++;

			Destroy(gameObject);

		}

	}	

}
