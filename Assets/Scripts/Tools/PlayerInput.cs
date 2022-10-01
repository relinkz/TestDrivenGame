using UnityEngine;

namespace Tools
{
	public class PlayerInput
	{
		public static Vector2 GetPlayerInputDirection()
		{
			return  new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		}
	}
}

