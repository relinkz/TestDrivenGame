using UnityEngine;

public class InputHandler : MonoBehaviour
{
	Player player;
	// Start is called before the first frame update
	void Start()
	{
		player = FindObjectOfType<Player>();
	}

	private void HandleMovement()
	{
		var x = Input.GetAxis("Horizontal");

		Vector2 direction = new Vector2(x, 0.0f);
		direction.Normalize();

		player.ApplyForce(direction);
	}

	private void HandleJump()
	{
		player.Jump();
	}
	// Update is called once per frame
	void Update()
	{
		HandleMovement();
	}
}
