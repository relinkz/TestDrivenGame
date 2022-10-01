using UnityEngine;
using Interfaces;

public class Despawner : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		var destroyable = collision.gameObject.GetComponent<IDestroyable>();
		if (destroyable != null)
		{
			destroyable.Destroyable();
		}
	}
}
