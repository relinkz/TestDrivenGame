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