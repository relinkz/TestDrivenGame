using UnityEngine;

namespace Tools
{
	public class MathHelpers
	{
		public static Quaternion CreateRotateQuat(Vector2 before, Vector2 after)
		{
			var dot = Mathf.Acos(Vector2.Dot(before, after));
			dot *= Mathf.Rad2Deg;

			return Quaternion.Euler(0.0f, 0.0f, dot);
		}
	}
}