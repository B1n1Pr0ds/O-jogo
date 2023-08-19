//This script controls the player stats, such as HP, MP, Damage, Stamina, etc....
//===========================================================================================================================


using UnityEngine;
public class PlayerStats : MonoBehaviour
{
 //The stats are subdivided by the following list
 /*Body: Controls the HP, Strength  and defense (Physical damage, interaction with heavy objects, and weight carrying*/
 /*Soul: Mana quantity, quality and magic defense*/
 /*Mind: Speech, Intelligence and Posture */

 private float playerXP;
 private float xpToNextLevel;
 private int playerLevel;

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


 private bool inUI;
 private bool inventoryWindowOpenned;
 private bool playerStatsWindowOpenned;

 [SerializeField] private GameObject playerStats;
 [SerializeField] private GameObject playerInventory;
 [SerializeField] private GameObject uiinGame;
 

 public int essentialLevels;
 public int bodyLevels;
 public int mindLevels;
 public int soulLevels;


 
 
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
//==================================================PlayerManager======================================================//
    public float GetPlayerXP()
    {
        return playerXP;
    }

    public void SetPlayerXP(float _playerXp)
    {
        playerXP = _playerXp;
    }

    public void AddPlayerXP(float _amount)
    {
        playerXP += _amount;
    }

    public float GetPlayerXPtoNextLevel()
    {
        return xpToNextLevel;
    }

    public int GetPlayerLevel()
    {
        return playerLevel;
    }

    public void SetPlayerLevel(int _level)
    {
        playerLevel = _level;
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
     xpToNextLevel = 100;
     SetPlayerLevel(0);

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
         if (inUI)
         {
             CloseUI();
         }

         else
         {
             OpenUI(playerStats);
         }
     }
     if(Input.GetKeyDown(KeyCode.I))
     {
         if (inUI)
         {
             CloseUI();
         }

         else
         {
             OpenUI(playerInventory);
         }
     }
     if (inUI)
     {
         if (playerStatsWindowOpenned)
         {
             if (Input.GetKeyDown(KeyCode.D))
             {
                 playerStats.SetActive(false);
                 playerStatsWindowOpenned = false;
                 playerInventory.SetActive(true);
                 inventoryWindowOpenned = true;
             }
         }

         if (inventoryWindowOpenned)
         {
             if (Input.GetKeyDown(KeyCode.A))
             {
                 playerInventory.SetActive(false);
                 inventoryWindowOpenned = false;
                 playerStats.SetActive(true);
                 playerStatsWindowOpenned = true;
             }
         }
     }

     if (Input.GetKeyDown(KeyCode.UpArrow))
     {
         AddPlayerXP(100);
     }
     

     //=====================================================================================================================//
     if (playerXP >= xpToNextLevel)
     {
         LevelUP();
     }
 }
 
 
 
 private void OpenUI(GameObject _uIToOpen)
 {
     inUI = true;
     _uIToOpen.SetActive(true);
     if (_uIToOpen == playerStats)
     {
         playerStatsWindowOpenned = true;
     }
     else if (_uIToOpen == playerInventory)
     {
         inventoryWindowOpenned = true;
     }
     
     uiinGame.SetActive(false);
     
 
}

 private void CloseUI()
 {
     playerInventory.SetActive(false);
     inventoryWindowOpenned = false;
     playerStats.SetActive(false);
     playerStatsWindowOpenned = false;
     inUI = false;
     uiinGame.SetActive(true);

 }

 private void LevelUP()
 {
     xpToNextLevel = xpToNextLevel * 2;
     SetPlayerLevel(playerLevel+1);
     essentialLevels += 1;
 }

 //==================================================LevelUpBodySection================================================//
 public void LevelUpBody()
 {
     essentialLevels -= 1;
     SetPlayerBody(GetPlayerBody()+1);
     bodyLevels += 1;
     SetPlayerMaxHP(GetPlayerMaxHP()+ (100 * playerLevel / 2) );
     SetPlayerHP(GetPlayerMaxHP());
     SetPlayerStrength(GetPlayerStrength()+(1*playerLevel/2));
     SetPlayerPhysicalDefense(GetPlayerPhysicalDefense()+(1*playerLevel/2));
 }

 public void LevelUpHP()
 {
     bodyLevels -= 1;
     SetPlayerMaxHP(GetPlayerMaxHP() + 100 * playerLevel);
     SetPlayerHP(GetPlayerMaxHP());
     
 }

 public void LevelUpStr()
 {
     bodyLevels -= 1;
     SetPlayerStrength(GetPlayerStrength()+1 * playerLevel);
 }

 public void LevelUpDef()
 {
     bodyLevels -= 1;
     SetPlayerPhysicalDefense(GetPlayerPhysicalDefense()+1*playerLevel);
 }
//====================================================================================================================//
//==================================================LevelUpSoulSection================================================//
    public void LevelUpSoul()
    {
        essentialLevels -= 1;
        SetPlayerSoul(GetPlayerSoul()+1);
        soulLevels += 1;
        SetPlayerMaxMP(GetPlayerMaxMP()+ (50 * playerLevel / 2));
        SetPlayerMP(GetPlayerMaxMP());
        SetPlayerMPQuality(GetPlayerMPQuality()+(1*playerLevel/2));
        SetPlayerMagicDefense(GetPlayerMagicDefense()+(1*playerLevel/2));
    }
    public void LevelUpMP()
    {
        soulLevels -= 1;
        SetPlayerMaxMP(GetPlayerMaxMP() +(50 * playerLevel));;
        SetPlayerMP(GetPlayerMaxMP());
    }
    public void LevelUpMPQ()
    {
        soulLevels -= 1;
        SetPlayerMPQuality(GetPlayerMPQuality() + (1*playerLevel));
    }

    public void LevelUpMDef()
    {
        soulLevels -= 1;
        SetPlayerMagicDefense(GetPlayerMagicDefense() + (1*playerLevel));
    }
//====================================================================================================================//
//===============================================LevelUpMindSection===================================================//
    public void LevelUPMind()
    {
        essentialLevels -= 1;
        SetPlayerMind(GetPlayerMind()+1);
        mindLevels += 1;
    }
//====================================================================================================================//
}

