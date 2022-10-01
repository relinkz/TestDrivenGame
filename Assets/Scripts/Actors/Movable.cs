using System.Collections;
using UnityEngine;

namespace Actors
{
	public abstract class Movable : MonoBehaviour
	{
		public void Move(Vector2 direction, float scalar)
		{
			transform.Translate(direction * scalar, Space.World);
		}
	}
}