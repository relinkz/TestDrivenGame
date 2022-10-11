using UnityEngine;
using Interfaces;

namespace Actors
{
	public class SimpleDirectionMover : Movable, IHealth
	{
		[SerializeField] uint speed = 1;
		[SerializeField] Vector2 direction = Vector2.left;

		public int Health => throw new System.NotImplementedException();

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

		private void Start()
		{
			transform.rotation = Tools.MathHelpers.CreateRotateQuat(transform.forward, direction);
		}

		private void Update()
		{
			Move(direction.normalized, (speed / 100.0f));
		}
	}
}