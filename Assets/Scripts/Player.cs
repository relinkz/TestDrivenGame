using UnityEngine;

public class Player : MonoBehaviour
{
	int health = 10;
	[SerializeField] float movementScalar = 0.05f;
	Rigidbody2D rb;

	private void FetchRigidBodyIfLost()
	{
		if (rb == null)
		{
			rb = GetComponent<Rigidbody2D>();
		}
	}
	private void Start()
	{
		FetchRigidBodyIfLost();
	}
	public Vector2 ApplyForce(Vector2 direction)
	{
		FetchRigidBodyIfLost();

		var force = direction * movementScalar;
		rb.AddForce(force, ForceMode2D.Impulse);
		return force;
	}

	public Vector2 ApplyForce(Vector2 direction, float scalar)
	{
		FetchRigidBodyIfLost();

		var force = direction * scalar;
		rb.AddForce(force, ForceMode2D.Impulse);
		return force;
	}

	public void Jump()
	{
		// todo
	}

	public void DestroyPlayerIfDead()
	{
		if (health > 0)
		{
			Debug.Log("Player died");
		}
	}

	public int ApplyDamage(int value)
	{
		health -= value;
		return health;
	}

	public int ApplyHealth(int value)
	{
		health += value;
		return health;
	}
}
