using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ValueBar : MonoBehaviour
{
    public Slider slider;
    public Image fill;

    public void SetMaxValue(int value)
    {
        slider.maxValue = value;
        slider.value = value;

    }

    public void SetValue(int value)
    {
        slider.value = value;
    }
}
