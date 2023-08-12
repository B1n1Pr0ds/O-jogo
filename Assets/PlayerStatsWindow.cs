

using TMPro;
using UnityEngine;


public class PlayerStatsWindow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI statsTitle;

    [Header("Body")]
    [SerializeField] private TextMeshProUGUI bodyLabel;
    [SerializeField] private TextMeshProUGUI playerMaxHp;
    [SerializeField] private TextMeshProUGUI playerStrength;
    [SerializeField] private TextMeshProUGUI playerPhysicDefense;

    [Header("Soul")]
    [SerializeField] private TextMeshProUGUI soulLabel;
    [SerializeField] private TextMeshProUGUI playerMaxMp;
    [SerializeField] private TextMeshProUGUI playerMagicDefense;
    [SerializeField] private TextMeshProUGUI playerMPquality;
    
    [Header("Mind")]
    [SerializeField] private TextMeshProUGUI mindLabel;
    [SerializeField] private TextMeshProUGUI playerMaxStamina;
    [SerializeField] private TextMeshProUGUI playerItelligence;
    [SerializeField] private TextMeshProUGUI playerPosture;

    [SerializeField] PlayerStats _playerStats;
    



    private void OnEnable()
    {
        statsTitle.text = "Player Stats";
        
        bodyLabel.text = "Body: " + _playerStats.GetPlayerBody();
        playerMaxHp.text = "HP: " + _playerStats.GetPlayerHP().ToString() + "/" + _playerStats.GetPlayerMaxHP();
        playerStrength.text = "Str: " + _playerStats.GetPlayerStrength();
        playerPhysicDefense.text = "PDef: " + _playerStats.GetPlayerPhysicalDefense();

        soulLabel.text = "Soul: " + _playerStats.GetPlayerSoul();
        playerMaxMp.text = "MP: " + _playerStats.GetPlayerMP().ToString() + "/" + _playerStats.GetPlayerMaxMP();
        playerMPquality.text = "MPQ: " + _playerStats.GetPlayerMPQuality();
        playerMagicDefense.text = "MDef: " + _playerStats.GetPlayerMagicDefense();

        mindLabel.text = "Mind: " + _playerStats.GetPlayerMind();
        playerMaxStamina.text = "Sta: " + _playerStats.GetPlayerStamina().ToString() + "/" + _playerStats.GetPlayerMaxStamina();
        playerItelligence.text = "Int: " + _playerStats.GetPlayerIntelligence();
        playerPosture.text = "Pos: " + _playerStats.GetPlayerPosture();
    }
}
