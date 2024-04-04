using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculator : MonoBehaviour
{
    public float sum1;
    public float sum2;
    [HideInInspector] public float resultSum;
    [Space]

    public float min1;
    public float min2;
    [HideInInspector] public float resultMin;
    [Space]

    public float mult1;
    public float mult2;
    [HideInInspector] public float resultMult;
    [Space]

    public float div1;
    public float div2;
    [HideInInspector] public float resultDiv;

    void Start()
    {
        Sum(); Min(); Mult(); Div();
    }

    public void Sum()
    {
        resultSum = sum1 + sum2;
        Debug.Log(resultSum);
    }

    public void Min()
    {
        resultMin = min1 - min2;
        Debug.Log(resultMin);
    }

    public void Mult()
    {
        resultMult = mult1 * mult2;
        Debug.Log(resultMult);
    }

    public void Div()
    {
        resultDiv = div1 / div2;
        Debug.Log(resultDiv);
    }
}
