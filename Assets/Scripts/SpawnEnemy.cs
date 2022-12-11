using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject enemyPrefab;

    IEnumerator SpawnEnemyAtPoint()
    {

        yield return null;
    }
}
