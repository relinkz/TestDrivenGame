using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	float clock = 0;
	[SerializeField] float timePerSpawn = 3.0f;
	[SerializeField] GameObject rockets;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		clock += Time.deltaTime;

		var newspawn = timePerSpawn - clock;
		if (newspawn < 0.0f)
		{
			clock = 0;

			Instantiate(rockets, new Vector3(8.0f, 0.0f, 0.0f), Quaternion.identity);
		}
	}
}
