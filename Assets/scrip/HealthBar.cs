using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image FillBar;
    public TextMeshProUGUI valueText;

    // Update is called once per frame
    public void UpdateBar(float currentValue ,int maxValue)
    {
        FillBar.fillAmount = (float)currentValue / (float) maxValue;
        valueText.text = currentValue.ToString() + "/" + maxValue.ToString();
    }


}
