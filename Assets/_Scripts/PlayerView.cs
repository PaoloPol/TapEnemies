using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private Image playerHealthBarFill;
    [SerializeField] private Button playerButtonAttack;
    [SerializeField] private Button playerButtonHeal;
    [SerializeField] private TextMeshProUGUI playerHealCounter;
}
