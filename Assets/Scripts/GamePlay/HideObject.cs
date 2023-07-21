using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObject : MonoBehaviour
{
    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
