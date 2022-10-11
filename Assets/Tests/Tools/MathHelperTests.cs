using NUnit.Framework;
using UnityEngine;
using Tools;
public class MathHelperTests
{
	// A Test behaves as an ordinary method
	[Test]
	public void MathHelpTest_UpDotLeft()
	{
		var expected = Quaternion.Euler(0.0f, 0.0f, 90);
		Assert.AreEqual(expected, MathHelpers.CreateRotateQuat(Vector2.up, Vector2.left));
	}

	// A Test behaves as an ordinary method
	[Test]
	public void MathHelpTest_UpDotRight()
	{
		var expected = Quaternion.Euler(0.0f, 0.0f, 90);
		Assert.AreEqual(expected, MathHelpers.CreateRotateQuat(Vector2.up, Vector2.right));
	}

	// A Test behaves as an ordinary method
	[Test]
	public void MathHelpTest_LeftDotRight()
	{
		var expected = Quaternion.Euler(0.0f, 0.0f, 180);
		Assert.AreEqual(expected, MathHelpers.CreateRotateQuat(Vector2.left, Vector2.right));
	}
}
