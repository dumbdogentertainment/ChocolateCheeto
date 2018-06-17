using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class TileSpawnerScript : MonoBehaviour
{
	public float minSpawnCooldown = 0.15f;

	public float maxSpawnCooldown = 0.25f;
	
	private float spawnCooldownRemaining;

	[SerializeField]
	private GameObject[] TilePrefabs;

	private BoxCollider2D spawnerCollider;

    private GameObject tileParent;

	private void Start()
	{
		this.spawnerCollider = GetComponent<BoxCollider2D>();
		this.spawnCooldownRemaining = Random.Range(this.minSpawnCooldown, this.maxSpawnCooldown);

        this.tileParent = GameObject.Find("GameBoard");
	}

	private void Update()
	{
		this.spawnCooldownRemaining -= Time.deltaTime;

		if(spawnCooldownRemaining <= 0f)
		{
			SpawnTile();
			this.spawnCooldownRemaining = Random.Range(this.minSpawnCooldown, this.maxSpawnCooldown);
		}
	}

	private void SpawnTile()
	{
		if (this.spawnerCollider.IsTouchingLayers())
		{
			return;
		}
		
		var randomIndex = Random.Range(0, this.TilePrefabs.Length);
        Instantiate(this.TilePrefabs[randomIndex], this.transform.position, Quaternion.identity, this.tileParent.transform);
	}
}