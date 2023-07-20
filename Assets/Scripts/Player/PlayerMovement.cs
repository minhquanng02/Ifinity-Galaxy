using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rgb;
    float speed = 10f;

    public void Move(float buttonX, float buttonY)
    {
        Vector2 move;
        move.x = buttonX;
        move.y = buttonY;

        rgb.MovePosition(rgb.position + move * speed * Time.deltaTime);
    }

    public void Rotate(Vector2 mousePos)
    {
        Vector2 dir = mousePos - rgb.position;
        dir.Normalize();

        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;

        rgb.rotation = angle;
    }
}
