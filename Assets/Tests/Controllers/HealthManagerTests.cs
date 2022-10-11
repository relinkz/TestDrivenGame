using Assets.Scripts.Controllers;
using NUnit.Framework;
using NSubstitute;
using Interfaces;

[TestFixture]
public class HealthManagerTests
{
	HealthManager sut;
	[SetUp]
	public void SetUp()
	{
		sut = new HealthManager();
	}
	[Test]
	public void DestroyAll_ShouldReturn0_WhenNoDestroyableExist()
	{
		// act
		int actual = sut.DestroyAll();

		// assert
		int expected = 0;
		Assert.AreEqual(expected, actual);
	}

	[Test]
	public void DestroyAll_ShouldReturn1_When1DestroyableExist()
	{
		// assemble
		var substitute = Substitute.For<IHealth>();
		sut.Add(substitute);

		// act
		int actual = sut.DestroyAll();

		// assert
		int expected = 1;
		Assert.AreEqual(expected, actual);
	}

	[Test]
	public void DamageAll_ShouldReturn1_When4()
	{
		// assemble
		int damage = 4;
		int hpLeft = 1;
		
		var substitute = Substitute.For<IHealth>();
		sut.Add(substitute);

		substitute.TakeDamage(damage).Returns(hpLeft);

		// act
		sut.DmgAll(damage);

		// assert
		int expected = 1;
		Assert.AreEqual(expected, sut.GetEntries());
	}

	[Test]
	public void DamageAll_ShouldBeDestoyed_WhenReturn0()
	{
		// assemble
		int damage = 4;
		int hpLeft = 0;

		var substitute = Substitute.For<IHealth>();
		sut.Add(substitute);

		substitute.TakeDamage(damage).Returns(hpLeft);

		// act
		sut.DmgAll(damage);

		// assert
		int expected = 0;
		Assert.AreEqual(expected, sut.GetEntries());
	}

	[Test]
	public void DamageAll_ShouldBeDestoyed_WhenReturnNeg1()
	{
		// assemble
		int damage = 4;
		int hpLeft = -1;

		var substitute = Substitute.For<IHealth>();
		sut.Add(substitute);

		substitute.TakeDamage(damage).Returns(hpLeft);

		// act
		sut.DmgAll(damage);

		// assert
		int expected = 0;
		Assert.AreEqual(expected, sut.GetEntries());
	}

	[Test]
	public void DamageAll_2ShouldBeDestoyed_When2Return0()
	{
		// assemble
		int damage = 4;
		int hpDead = 0;
		int hpLeft = 1;

		var substitute1 = Substitute.For<IHealth>();
		var substitute2 = Substitute.For<IHealth>();
		var substitute3 = Substitute.For<IHealth>();
		
		sut.Add(substitute1);
		sut.Add(substitute2);
		sut.Add(substitute3);

		substitute1.TakeDamage(damage).Returns(hpDead);
		substitute2.TakeDamage(damage).Returns(hpLeft);
		substitute3.TakeDamage(damage).Returns(hpDead);

		// act
		sut.DmgAll(damage);

		// assert
		int expected = 1;
		Assert.AreEqual(expected, sut.GetEntries());
	}
}
