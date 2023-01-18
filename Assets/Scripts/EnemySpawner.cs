using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public AnimationCurve SpawnCooldownOverTime;

    private float spawnCooldown = 0;

    void Update()
    {
        if (spawnCooldown <= 0) {
            // Hard-coded position, could be changed
            Instantiate(EnemyPrefab, new Vector3 (Random.Range (-6f, 6f), 8, 0), Quaternion.identity, null);
            spawnCooldown = SpawnCooldownOverTime.Evaluate(Time.time);
        }

        spawnCooldown -= Time.deltaTime;
    }
}
