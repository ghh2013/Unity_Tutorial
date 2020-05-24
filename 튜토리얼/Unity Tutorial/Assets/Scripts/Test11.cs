using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test11 : MonoBehaviour
{
    [SerializeField]private Text txt_name;
    [SerializeField] private Image img_name;
    [SerializeField] private Sprite sprite;

    private bool isCoolTime = false;

    private float currentTime = 5f;
    private float delayTIme = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color color = img_name.color;
        color.a = 0f;
        img_name.color = color;

        if (isCoolTime)
        {
            currentTime -= Time.deltaTime;
            img_name.fillAmount = currentTime / delayTIme;

            if (currentTime < 0)
            {
                isCoolTime = false;
                currentTime = delayTIme;
                img_name.fillAmount = currentTime;
            }
        }
    }

    public void Change()
    {
        txt_name.text = "변경됨";
        img_name.fillAmount = 0.5f;
    }
}
