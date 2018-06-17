using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawnerGroupScript : MonoBehaviour
{
	[SerializeField]
	private float spacing = 0.5f;

	[SerializeField]
	private float minPositionX = -2.5f;
	
	[SerializeField]
	private float maxPositionX = 2.5f;
	
	[SerializeField]
	private GameObject TileSpawner;

	void Start()
	{
		for(var i = this.minPositionX; i <= this.maxPositionX; i += this.spacing)
		{
			var position = new Vector3
			{
				x = i,
				y = this.transform.position.y,
				z = this.transform.position.z
			};

			Instantiate(this.TileSpawner, position, Quaternion.identity, this.transform);
		}
	}
}