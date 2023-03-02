using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    private Transform target;
    public float speed;
    Rigidbody2D rb;
    Vector3 lastVelocity;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("User").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(1800*Time.deltaTime* speed, 1800 * Time.deltaTime * speed));
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 distance = target.position - transform.position;

        lastVelocity = rb.velocity;

        if (distance.magnitude < 1.25)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }
        

     
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0f);
    }


}
