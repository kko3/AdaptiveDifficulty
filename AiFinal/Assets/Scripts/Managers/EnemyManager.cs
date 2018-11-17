using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
    //type of enemy being spawned **for testing purposes**
    //public string enemyName = "PlaceHolder";
    public float timeTilSpawn= 3f;
    public float timeBetweenSpawn = 3f;
    public int spawnCount = 10;
    public int enemyWaves = 3;
    public Transform[] spawnPoints;

    void Start ()
    {
        InvokeRepeating("Spawn", timeTilSpawn, timeBetweenSpawn);
    }

    void Update()
    {
    }


    void Spawn ()
    {
        if (playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        if (--spawnCount == 0) { CancelInvoke("Spawn"); }
        //Debug.Log(enemyName + " Spawn Count: " + spawnCount);
    }
}
