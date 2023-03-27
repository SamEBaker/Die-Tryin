using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public playerMovement movement;

	void OnCollisionEnter (Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacles")
		{
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
			Debug.Log("You Died");
		}
	}
}
