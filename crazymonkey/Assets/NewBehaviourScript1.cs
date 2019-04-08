using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {

	public Transform[] patrolpoints;
    int currentPoint;
    public float speed = 0.5f;

    void Start()
    {

        StartCoroutine("Patrol");

    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit2D hit =  Physics2D.Raycast(transform.position, transform.localScale.x * Vector2.right, slight);//гнатться за героем
        // if (hit.collider != null && hit.collider.tag == "shitss")
        //   GetComponent<Rigidbody2D>().AddForce(Vector3.up*force + (hit.collider.transform.position-transform.position)*force);//гнатться за героем
    }

    IEnumerator Patrol()
    {
        while (true)
        {
            if (transform.position.y == patrolpoints[currentPoint].position.y)
            {
                currentPoint++;

            }

            if (currentPoint >= patrolpoints.Length)
            {
                currentPoint = 0;
            }

            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, patrolpoints[currentPoint].position.y, transform.position.z), speed);

            yield return null;

        }


    }
    // void OnDrawGizmos()
    // {
    //   Gizmos.color = Color.red;
    //   Gizmos.DrawLine(transform.position, transform.position + transform.localScale.x * Vector3.right * slight);//гнатться за героем
    // }

}
