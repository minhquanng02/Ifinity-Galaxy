using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float distance = 50f;
    float speed = 10f;

    public GameObject impactEffect;

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);

        DestroyByDistance();
    }

    void DestroyByDistance()
    {
        var cam = Camera.main;
        var distanceFromCamera = Vector3.Distance(transform.position, cam.transform.position);

        if (distanceFromCamera > distance)
        {
            ResetObject();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        GameObject effect = Instantiate(impactEffect, transform.position, Quaternion.identity);
        Destroy(effect, 2f);
        ResetObject();
    }

    void ResetObject()
    {
        gameObject.SetActive(false);
        transform.position = Vector3.zero;
    }
}
