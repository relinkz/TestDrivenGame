using UnityEngine;
using Interfaces;

namespace Actors
{
	public class Player : Movable, IHealth
	{
		int health;
		[SerializeField] private float speed = 1.0f;
		public readonly float maxX = 8.5f;
		public readonly float maxY = 4.5f;

		public int Health => health;

		public Vector2 RemoveXDirectionIfOutsideScreen(Vector2 dir)
		{
			if (dir.x > 0.0f)
			{
				// right
				if (transform.position.x > maxX)
				{
					dir.x = 0.0f;
				}
			}
			else if (dir.x < 0.0f)
			{
				// left
				if (transform.position.x < -maxX)
				{
					dir.x = 0.0f;
				}
			}

			return dir;
		}

		public Vector2 RemoveYDirectionIfOutsideScreen(Vector2 dir)
		{
			if (dir.y > 0.0f)
			{
				// right
				if (transform.position.y > maxY)
				{
					dir.y = 0.0f;
				}
			}
			else if (dir.y < 0.0f)
			{
				// left
				if (transform.position.y < -maxY)
				{
					dir.y = 0.0f;
				}
			}

			return dir;
		}
		private void HandleMovement()
		{
			var playerDirection = Tools.PlayerInput.GetPlayerInputDirection();
			playerDirection = RemoveXDirectionIfOutsideScreen(playerDirection);
			playerDirection = RemoveYDirectionIfOutsideScreen(playerDirection);

			var scalar = speed / 100.0f;
			Move(playerDirection, scalar);
		}
		// Interface functions
		private void Update()
		{
			HandleMovement();
		}

		public void Destroy()
		{
			Destroy(gameObject);
		}

		public void Heal(int healing)
		{
			throw new System.NotImplementedException();
		}

		public int TakeDamage(int dmg)
		{
			throw new System.NotImplementedException();
		}
	}
}