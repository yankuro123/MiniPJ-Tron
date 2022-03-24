using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int speed = 10;
    public GameObject WallPrefab;
    Collider2D Wall;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
            SpawnWall();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
            SpawnWall();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
            SpawnWall();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;
            SpawnWall();
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
        //Player losing
    }

    void SpawnWall()
    {
        GameObject Inst = Instantiate(WallPrefab, transform.position, Quaternion.identity);
        Wall = Inst.GetComponent<Collider2D>();
    }
}
