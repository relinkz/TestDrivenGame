using UnityEngine;
using Interfaces;

namespace Actors
{
	public class SimpleDirectionMover : Movable, IDestroyable
	{
		[SerializeField] uint speed = 1;
		[SerializeField] Vector2 direction = Vector2.left;

		public void Destroyable()
		{
			Destroy(gameObject);
		}

		private void Update()
		{
			Move(direction.normalized, (speed / 100.0f));
		}
	}
}