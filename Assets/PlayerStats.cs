//This script controls the player stats, such as HP, MP, Damage, Stamina, etc....
//===========================================================================================================================


using UnityEngine;
public class PlayerStats : MonoBehaviour
{
 //The stats are subdivided by the following list
 /*Body: Controls the HP, Strength  and defense (Physical damage, interaction with heavy objects, and weight carrying*/
 /*Soul: Mana quantity, quality and magic defense*/
 /*Mind: Speech, Intelligence and Posture */

 private int playerBody;
 private float playerHP;
 private float playerMaxHP;
 private float playerStrength;
 private float playerPhysicalDefense;

 private int playerSoul;
 private float playerMP;
 private float playerMaxMP;
 private float playerQualityMP;
 private float playerMagicDefense;

 private int playerMind;
 private float playerMaxStamina;
 private float playerIntelligence;
 private float playerStamina;
 private float playerPosture;


 private bool inventoryOpened = false;
 [SerializeField] private GameObject playerStats;
 [SerializeField] private GameObject uiinGame;

 private PlayerStatsWindow _playerStatsWindow;
 
 
 //=============================================Body=================================================//
 public void SetPlayerMaxHP(float _maxHP)
 {
     playerMaxHP = _maxHP;
 }

 public float GetPlayerMaxHP()
 {
     return playerMaxHP;
 }

 public void SetPlayerHP(float _hp)
 {
     playerHP = _hp;
 }
 public float GetPlayerHP()
 {
     return playerHP;
 }

 public void SetPlayerStrength(float _strength)
 {
     playerStrength = _strength;
 }

 public float GetPlayerStrength()
 {
     return playerStrength;
 }

 public void SetPlayerPhysicalDefense(float _physicalDefense)
 {
     playerPhysicalDefense = _physicalDefense;
 }
 public float GetPlayerPhysicalDefense()
 {
     return playerPhysicalDefense;
 }

 public void SetPlayerBody(int _bodyLevel)
 {
     playerBody = _bodyLevel;
 }
 public int GetPlayerBody()
 {
     return playerBody;
 }
     
 //=================================================================================================//
 //=================================================Soul============================================//
 public void SetPlayerMaxMP(float _maxMP)
 {
     playerMaxMP = _maxMP;
 }
 public float GetPlayerMaxMP()
 {
     return playerMaxMP;
 }
 public void SetPlayerMP(float _mp)
 {
     playerMP = _mp;
 }

 public float GetPlayerMP()
 {
     return playerMP;
 }

 public void SetPlayerMPQuality(float _MPQuality)
 {
     playerQualityMP = _MPQuality;
 }
 public float GetPlayerMPQuality()
 {
     return playerQualityMP;
 }

 public void SetPlayerMagicDefense(float _magicDefense)
 {
     playerMagicDefense = _magicDefense;
 }
 public float GetPlayerMagicDefense()
 {
    return playerMagicDefense;
 }

 public void SetPlayerSoul(int _levelSoul)
 {
     playerSoul = _levelSoul;
 }
 public int GetPlayerSoul()
 {
     return playerSoul;
 }
//===============================================================================================================//
//=====================================================Mind======================================================//
    public void SetPlayerMind(int _mindLevel)
    {
        playerMind = _mindLevel;
    }

    public int GetPlayerMind()
    {
        return playerMind;
    }
    public void SetPlayerMaxStamina(float _maxStamina)
    {
        playerMaxStamina = _maxStamina;
    }
    public float GetPlayerMaxStamina()
    {
        return playerMaxStamina;
    }
    public void SetPlayerStamina(float _stamina)
    {
        playerStamina = _stamina;
    }
    public float GetPlayerStamina()
    {
        return playerStamina;
    }

    public void SetPlayerIntelligence(float _intelligence)
    {
        playerIntelligence = _intelligence;
    }

    public float GetPlayerIntelligence()
    {
        return playerIntelligence;
    }

    public void SetPlayerPosture(float _posture)
    {
        playerPosture = _posture;
    }
    public float GetPlayerPosture()
    {
        return playerPosture;
    }
    
//=====================================================================================================================//







 public void PlayerTakeDamage(float _damage)
 {
     playerHP -= _damage;
 } 


 private void Start()
 {
     SetPlayerMaxHP(100);
     SetPlayerHP(playerMaxHP);
     _playerStatsWindow = gameObject.GetComponent<PlayerStatsWindow>();
 }

 private void Update()
 {
     if (playerHP <= 0)
     {
         //die
         Debug.Log("Player Dead");
         gameObject.SetActive(false);
     }
     
//=======================================================DebugFunction==================================================//
     if (Input.GetKeyDown(KeyCode.K))
     {
         PlayerTakeDamage(10);
     }
     if(Input.GetKeyDown(KeyCode.Y))
     {
         if (inventoryOpened)
         {
             ClosePlayerStats();
         }

         else
         {
             OpenPlayerStats();
         }
         
     }
     //=====================================================================================================================//
 }
 
 private void OpenPlayerStats()
 {
     inventoryOpened = true;
     playerStats.SetActive(true);
     _playerStatsWindow.SetPlayerIventory();
     uiinGame.SetActive(false);
     
 
}

 private void ClosePlayerStats()
 {
     
     playerStats.SetActive(false);
     inventoryOpened = false;
     uiinGame.SetActive(true);

 }
 

}

