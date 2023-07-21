using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PlayerInput : MonoBehaviour
{
    public UnityEvent<float, float> OnMove = new UnityEvent<float, float>();
    public UnityEvent<Vector2> OnLook = new UnityEvent<Vector2>();
    public UnityEvent OnShoot = new UnityEvent();

    float buttonX;
    float buttonY;
    Vector2 mousePos;

    void Update()
    {
        GetInput();
        GetPlayerMove(buttonX, buttonY);
        GetPlayerRotate(mousePos);
        GetPlayerShoot();
    }

    void GetInput()
    {
        buttonX = Input.GetAxis("Horizontal");
        buttonY = Input.GetAxis("Vertical");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void GetPlayerMove(float buttonX, float buttonY)
    {
        OnMove?.Invoke(buttonX, buttonY);
    }

    private void GetPlayerRotate(Vector2 mousePos)
    {
        OnLook?.Invoke(mousePos);
    }

    private void GetPlayerShoot()
    {
        OnShoot?.Invoke();
    }
}
