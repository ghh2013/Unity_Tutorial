﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test13 : MonoBehaviour
{
    [SerializeField] private Text txt_Money;
    [SerializeField] private InputField inputTxT_Money;

    private int currentMoney;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Input()
    {
        currentMoney += int.Parse(inputTxT_Money.text);
        txt_Money.text = currentMoney.ToString();
    }

    public void Output()
    {
        currentMoney -= int.Parse(inputTxT_Money.text);
        txt_Money.text = currentMoney.ToString();
    }
}
