using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] int enemyAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        for (int i = 0; i < enemyAmount; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab);
            float randomX = Random.Range(-8, 8);
            float randomY = Random.Range(-4, 4);
            enemy.transform.position = new Vector3(randomX, randomY, 0);
            yield return new WaitForSeconds(1);
        }
    }
}
