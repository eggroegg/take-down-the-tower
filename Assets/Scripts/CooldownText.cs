using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CooldownText : MonoBehaviour
{
    public Shooting shooting;
    public float cooldown;
    public TextMeshProUGUI text;
    public string cooldownText;

    // Update is called once per frame
    void Update()
    {
        cooldown = shooting.fireRate;
        cooldownText = cooldown.ToString("#.00");
        text.text = cooldownText;
    }
}
