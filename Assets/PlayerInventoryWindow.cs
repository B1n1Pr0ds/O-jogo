using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInventoryWindow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textInventoryTitle;
    [SerializeField] private TextMeshProUGUI textEquippedNow;
    [SerializeField] private TextMeshProUGUI textOtherItems;


    private void OnEnable()
    {
        textInventoryTitle.text = "Inventory";
        textEquippedNow.text = "Equipped: ";
        textOtherItems.text = "Other Items";
    }
}
