using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;

public class calculatorVis : MonoBehaviour
{
    public Text text1;
    public string calc1;
    public string x1;

    public void OnClickButton()
    {
        text1.text += calc1;
    }

    public void OnCliickC()
    {
        text1.text = "";
    }

    public void OnCllickEqual()
    {
        DataTable dt = new DataTable();
        x1 = (dt.Compute(text1.text, "")).ToString();
        text1.text = x1;
    }
}
