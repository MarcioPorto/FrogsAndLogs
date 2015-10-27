using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

	// This is so I can associate the player's transform with this came script
	[SerializeField]
	private Transform player;
	// Offset between player and camera
	[SerializeField]
	private Vector3 offset;
	private float cameraFollowSpeed = 5f;
	
	// Update is called once per frame
	void Update () {

		Vector3 newPosition = player.position + offset;

		// transform.position is the current position of the camera
		// newPosition is the new position of the player, being updated every frame
		transform.position = Vector3.Lerp (transform.position, newPosition, cameraFollowSpeed * Time.deltaTime);

	}

}
