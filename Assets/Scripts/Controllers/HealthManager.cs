using System.Collections.Generic;
using UnityEngine;
using Interfaces;
using static UnityEditor.Progress;

namespace Assets.Scripts.Controllers
{
	public class HealthManager
	{
		[SerializeField] List<IHealth> entities;

		public HealthManager()
		{
			entities = new List<IHealth>();
		}
		public int DestroyAll()
		{
			foreach (var item in entities)
			{
				item.Destroy();
			}
			var nrDestroyed = entities.Count;
			entities.Clear();

			return nrDestroyed;
		}

		public void DmgAll(int dmg)
		{
			List<int> indexToRemove =	new List<int>();

			for (int i = 0; i < entities.Count; i++)
			{
				if (entities[i].TakeDamage(dmg) <= 0)
				{
					indexToRemove.Add(i);
				}
			}

			for (int i = 0; i < indexToRemove.Count; i++)
			{
				entities.RemoveAt(i);
			}
		}

		public void Add(IHealth entity)
		{
			entities.Add(entity);
		}

		public int GetEntries()
		{
			return entities.Count;
		}
	}
}