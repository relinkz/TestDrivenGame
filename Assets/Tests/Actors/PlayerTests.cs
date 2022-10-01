using NUnit.Framework;
using Actors;
using UnityEngine;

public class PlayerTests
{
	GameObject testPlayerObj;
	Player testPlayer;
	Transform testPlayerTransform;

	void SetUp() 
	{
		testPlayerObj = new GameObject();
		testPlayer = testPlayerObj.AddComponent<Player>();
		testPlayerTransform = testPlayerObj.GetComponent<Transform>();
	}

	// Given Player
	// When player position is (0,0) direction is (0,0)
	// Then direction return (0,0)
	[Test]
	public void RemoveXDirectionIfOutsideScreen_NotOutside()
	{
		SetUp();

		Vector2 expected = Vector2.zero;
		var actual = testPlayer.RemoveXDirectionIfOutsideScreen(expected);
		Assert.AreEqual(expected, actual);
	}

	// Given Player
	// When player position is (0,0) direction is (1,0)
	// Then direction return (1,0)
	[Test]
	public void RemoveXDirectionIfOutsideScreen_NotOutside_ValidMoveRight()
	{
		SetUp();

		Vector2 expected = Vector2.right;
		var actual = testPlayer.RemoveXDirectionIfOutsideScreen(expected);
		Assert.AreEqual(expected, actual);
	}

	// Given Player
	// When player position is (0,0) direction is (-1,0)
	// Then direction return (-1,0)
	[Test]
	public void RemoveXDirectionIfOutsideScreen_NotOutside_ValidMoveLeft()
	{
		SetUp();

		Vector2 expected = Vector2.left;
		var actual = testPlayer.RemoveXDirectionIfOutsideScreen(expected);
		Assert.AreEqual(expected, actual);
	}

	// Given Player
	// When player position is (8.5,0) direction is (1,0)
	// Then direction return (0,0)
	[Test]
	public void RemoveXDirectionIfOutsideScreen_Outside_Right()
	{
		SetUp();

		testPlayerTransform.position = new Vector3(testPlayer.maxX, 0, 0);

		Vector2 expected = Vector2.right;
		var actual = testPlayer.RemoveXDirectionIfOutsideScreen(expected);
		Assert.AreEqual(expected, actual);
	}

	// Given Player
	// When player position is (8.5,0) direction is (1,0)
	// Then direction return (0,0)
	[Test]
	public void RemoveXDirectionIfOutsideScreen_Outside_Left()
	{
		SetUp();

		testPlayerTransform.position = new Vector3(-testPlayer.maxX, 0, 0);

		Vector2 expected = Vector2.left;
		var actual = testPlayer.RemoveXDirectionIfOutsideScreen(expected);
		Assert.AreEqual(expected, actual);
	}

	// Given Player
	// When player position is (0,0) direction is (0,0)
	// Then direction return (0,0)
	[Test]
	public void RemoveYDirectionIfOutsideScreen_NotOutside()
	{
		SetUp();

		Vector2 expected = Vector2.zero;
		var actual = testPlayer.RemoveYDirectionIfOutsideScreen(expected);
		Assert.AreEqual(expected, actual);
	}

	// Given Player
	// When player position is (0,0) direction is (0,1)
	// Then direction return (0,1)
	[Test]
	public void RemoveYDirectionIfOutsideScreen_NotOutside_ValidMoveUp()
	{
		SetUp();

		Vector2 expected = Vector2.up;
		var actual = testPlayer.RemoveYDirectionIfOutsideScreen(expected);
		Assert.AreEqual(expected, actual);
	}

	// Given Player
	// When player position is (0,0) direction is (0,-1)
	// Then direction return (0,-1)
	[Test]
	public void RemoveYDirectionIfOutsideScreen_NotOutside_ValidMoveDown()
	{
		SetUp();

		Vector2 expected = Vector2.down;
		var actual = testPlayer.RemoveYDirectionIfOutsideScreen(expected);
		Assert.AreEqual(expected, actual);
	}

	// Given Player
	// When player position is (0,maxY) direction is (0,1)
	// Then direction return (0,0)
	[Test]
	public void RemoveXDirectionIfOutsideScreen_Outside_Up()
	{
		SetUp();

		testPlayerTransform.position = new Vector3(0, testPlayer.maxY, 0);

		Vector2 expected = Vector2.up;
		var actual = testPlayer.RemoveYDirectionIfOutsideScreen(expected);
		Assert.AreEqual(expected, actual);
	}

	// Given Player
	// When player position is (0,maxY) direction is (0,-1)
	// Then direction return (0,0)
	[Test]
	public void RemoveXDirectionIfOutsideScreen_Outside_Down()
	{
		SetUp();

		testPlayerTransform.position = new Vector3(0, -testPlayer.maxY, 0);

		Vector2 expected = Vector2.down;
		var actual = testPlayer.RemoveYDirectionIfOutsideScreen(expected);
		Assert.AreEqual(expected, actual);
	}
}
