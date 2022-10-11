using UnityEngine;
using Interfaces;

namespace Tools
{
	public class PlayerInput : IPlayerInput
	{
		public Vector2 GetPlayerInputDirection()
		{
			return  new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		}
	}
}

