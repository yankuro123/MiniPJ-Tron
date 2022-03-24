using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject Enemy;
    public float secondsBetweenSpawn;
    public float elapsedTime;
    Vector2 pointA = new Vector2(-10.95f, 6f);
    Vector2 pointB = new Vector2(10.95f, 6f);

    private Transform Spawn;
    private float Offset = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Spawn = GetComponent<Transform>();  
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time * 0.3f;
        secondsBetweenSpawn = 3.0f - Offset;
        transform.position = Vector2.Lerp(pointA, pointB, Mathf.PingPong(time, 1));
        elapsedTime += Time.deltaTime;
        if(elapsedTime > secondsBetweenSpawn)
        {
            Vector2 spawnPosition = new Vector2(Spawn.position.x, Spawn.position.y);
            GameObject newEnemy = (GameObject)Instantiate(Enemy, spawnPosition, Quaternion.identity);
            elapsedTime = 0;
            if(Offset < 2.5f)
            {
                Offset += .01f;
            }

        }
    }
}
