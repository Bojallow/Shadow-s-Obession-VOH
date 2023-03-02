//ASSALAM o alaikum Code:
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    public Transform[] allwayPoints;
    public float rotationSpeed = .5f, movementSpeed = 0.5f;
    public int currentTarget;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Movement();
        Rotate();
        ChangeTarget();
    }

    void Movement()
    {

        transform.position = Vector3.MoveTowards(transform.position, allwayPoints[currentTarget].position, movementSpeed * Time.deltaTime);
    }

    void Rotate()
    {

        transform.right = allwayPoints[currentTarget].position - transform.position;



    }

    void ChangeTarget()
    {
        if (transform.position == allwayPoints[currentTarget].position)
        {
            currentTarget++;
            currentTarget = currentTarget % allwayPoints.Length;
        }
    }


}

