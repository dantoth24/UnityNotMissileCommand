using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
	public GameObject missile;
	public float initialSpawnTime = 3f;
	public float successiveSpawnTime = 2f;
	public Transform[] spawnPoints;
    public GameObject gameOver;

	GameObject[] bases;
	int missilesFired = 0;
	int numToFire = 10;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", initialSpawnTime, successiveSpawnTime);
	}

	void Spawn() {
		bases = GameObject.FindGameObjectsWithTag ("Base");

		if (bases.Length == 0) {
			CancelInvoke ("Spawn");
            gameOver.SetActive(true);
			return;
		}

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		int baseIndex = Random.Range (0, bases.Length);

		GameObject firedMissile = Instantiate (missile, spawnPoints [spawnPointIndex].position,
			spawnPoints[spawnPointIndex].rotation);

		Transform baseTransform = bases [baseIndex].transform;
		firedMissile.GetComponent<MissileMovement> ().target = baseTransform;

		missilesFired++;

		if (missilesFired == numToFire && successiveSpawnTime > 0.2f) {
			successiveSpawnTime -= 0.2f;
			missilesFired = 0;
			CancelInvoke ("Spawn");
			InvokeRepeating ("Spawn", initialSpawnTime, successiveSpawnTime);
		}
	}
}