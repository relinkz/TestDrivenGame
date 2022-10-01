using NUnit.Framework;
using UnityEngine;

public class PlayerTest
{
	GameObject testPlayer;
	Player playerscript;

	private void SetUp()
	{
		testPlayer = new GameObject();
		testPlayer.AddComponent<BoxCollider2D>();
		testPlayer.AddComponent<Rigidbody2D>();
		playerscript = testPlayer.AddComponent<Player>();
	}

	// Given: Gameobject with a player component
	// When: ApplyForce called dir: left (-1, 0), scalar 0.05
	// Then: force (-0.05, 0) is returned
	[Test]
	public void ApplyForce_LeftDirection_ScalarWithDir()
	{
		SetUp();

		var result = playerscript.ApplyForce(Vector2.left);
		Vector2 expected = new Vector2(-0.05f, 0);

		Assert.AreEqual(expected, result);
	}

	// Given: Gameobject with a player component
	// When: ApplyForce called dir: left (-1, 0), scalar 10
	// Then: force (-0.05, 0) is returned
	[Test]
	public void ApplyForce_LeftDirectionAndScalar_ScalarWithDir()
	{
		SetUp();

		var result = playerscript.ApplyForce(Vector2.left, 10);
		Vector2 expected = new Vector2(-10f, 0);

		Assert.AreEqual(expected, result);
	}

	// Given: Gameobject with a player component
	// When: ApplyForce called dir: right (1, 0), scalar 0.05
	// Then: force (0.05, 0) is returned
	[Test]
	public void ApplyForce_RightDirection_ScalarWithDir()
	{
		SetUp();

		var result = playerscript.ApplyForce(Vector2.right);
		Vector2 expected = new Vector2(0.05f, 0);

		Assert.AreEqual(expected, result);
	}

	// Given: Gameobject with a player component
	// When: ApplyForce called dir: right (1, 0), scalar 10
	// Then: force (10, 0) is returned
	[Test]
	public void ApplyForce_RightDirectionAndScalar_ScalarWithDir()
	{
		SetUp();

		var result = playerscript.ApplyForce(Vector2.right, 10);
		Vector2 expected = new Vector2(10f, 0);

		Assert.AreEqual(expected, result);
	}
}