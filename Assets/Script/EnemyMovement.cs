using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public GameObject player;
    private Vector2 direction;
    public float speed = 1f;
    private float count;
    private bool oneHit;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (Mathf.Abs(direction.x) < 6f && Mathf.Abs(direction.y) < 6f)
        {
            MoveToPlayer();
        }
        else
        {
           Patrol();
        }
    }

    void Patrol()
    {
        count += Time.deltaTime;
        if (count >= 2) { transform.right = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)); count = 0; }

        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    void MoveToPlayer()
    {
        direction = (player.transform.position - transform.position);

        if (Mathf.Abs(direction.y) > 1.5 || Mathf.Abs(direction.x) > 1.5)
        {
            oneHit = true;
            transform.right = direction;
            transform.Translate(Vector3.right * Time.deltaTime * speed * 2);

        }
        else { if (oneHit) { print("attack"); oneHit = false; } }
    }
}
