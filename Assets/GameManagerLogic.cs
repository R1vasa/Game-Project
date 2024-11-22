using UnityEngine;

public class GameManagerLogic : MonoBehaviour
{
    public EnemyLogic enemyPrefab;

    public float currentInterval = 0f;
    public float interval = 2f;
    public float max = 2f;

    public bool GameOver = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameOver)
        {
            currentInterval += Time.deltaTime;
            if (currentInterval > interval)
            {
                currentInterval = 0;
                Vector3 spawnPoint = transform.position;
                spawnPoint.z = Random.Range(max, -max);
                EnemyLogic NewEnemy = Instantiate(enemyPrefab, spawnPoint, Quaternion.identity);
                //NewEnemy.gameManagerLogic = this;
            }
        
        }
    }
}
