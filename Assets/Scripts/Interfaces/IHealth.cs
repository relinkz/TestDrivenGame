using System.Runtime.InteropServices;

namespace Interfaces
{
	public interface IHealth
	{
		int Health
		{
			get;
		}

		void Heal(int healing);
		int TakeDamage(int dmg);

		void Destroy();
	}
}
