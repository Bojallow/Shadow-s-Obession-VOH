using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDestroy : MonoBehaviour
{
    public int value;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("User"))
        {
            Destroy(gameObject);
        }
    }
}
