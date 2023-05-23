using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int maxEnemy = 5;

    public float timeSpawn = 2f;
    private float timer;

    public float distance = 3;

    private void Start()
    {
        timer = timeSpawn;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = timeSpawn;
            if (transform.childCount < maxEnemy)
            {
                Instantiate(enemyPrefab, new Vector2 (Random.Range (-9f , 9f), 7f), Quaternion.identity, transform);
            }
        }
    }
}
