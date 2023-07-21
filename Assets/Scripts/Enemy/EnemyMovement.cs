using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    EnemySystem enemySystem;
    GameObject player;

    Rigidbody2D rgb;

    private void Start()
    {
        enemySystem = GetComponentInChildren<EnemySystem>();
        rgb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }
    void Update()
    {
        Move();
        Rotate();
    }

    public void Rotate()
    {

        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
    }

    private void Move()
    {
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, enemySystem.moveSpeed * Time.deltaTime);
    }
}
