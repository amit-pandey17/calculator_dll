using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using calc_library_dll;

public class calculator : MonoBehaviour
{
    public Calc helper = new Calc();
    public InputField numberx;
    public InputField numbery;

    public float number1x;
    public float number1y;
    public float ans;

    public Text answer;
    // Start is called before the first frame update
    void Start()
    {
        answer.text = "";
    }

    public void GetxInfo()
    {
        number1x = float.Parse(numberx.text);
    }

    public void GetyInfo()
    {
        number1y = float.Parse(numbery.text);
    }

    public void calculate_sum()
    {
        answer.text = "" + helper.add(number1x, number1y);
    }

    public void calculate_sub()
    {
        answer.text = "" + helper.subtract(number1x, number1y);
    }

    public void calculate_mul()
    {
        answer.text = "" + helper.multiply(number1x, number1y);
    }

    public void calculate_div()
    {
        answer.text = "" + helper.divide(number1x, number1y);
    }

}
