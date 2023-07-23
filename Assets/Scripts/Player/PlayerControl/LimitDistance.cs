using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitDistance : MonoBehaviour
{
    float range = 50f;

    void Update()
    {
        Distance();
    }

    void Distance()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -range, range), Mathf.Clamp(transform.position.y, -range, range), transform.position.z);
    }
}
