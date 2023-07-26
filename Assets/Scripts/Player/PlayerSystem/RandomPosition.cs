using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomPosition : MonoBehaviour
{
    float range = 40;

    private void Start()
    {
        transform.position = new Vector2(Random.Range(-range, range), Random.Range(-range, range));
    }
}
