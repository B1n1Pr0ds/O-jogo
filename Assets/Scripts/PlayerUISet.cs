

using TMPro;
using UnityEngine;

public class PlayerUISet : MonoBehaviour
{
 [SerializeField] private PlayerStats _playerStats;

 [SerializeField] private TextMeshProUGUI textHP;
 [SerializeField] private TextMeshProUGUI textSta;
 [SerializeField] private TextMeshProUGUI textMP;
 

 private void Update()
 {
  textHP.text = _playerStats.GetPlayerHP().ToString()+"/"+_playerStats.GetPlayerMaxHP().ToString();
  if (_playerStats.GetPlayerHP() < _playerStats.GetPlayerMaxHP() / 3)
  {
   textHP.color = Color.red;
  }

  textMP.text = _playerStats.GetPlayerMP().ToString() + "/" + _playerStats.GetPlayerMaxMP().ToString();
  if (_playerStats.GetPlayerMP() < _playerStats.GetPlayerMaxHP() / 3)
  {
   textMP.color = Color.magenta;
  }

  textSta.text = _playerStats.GetPlayerStamina().ToString() + "/" + _playerStats.GetPlayerMaxStamina().ToString();
  if (_playerStats.GetPlayerStamina() < _playerStats.GetPlayerMaxStamina() / 3)
  {
   textSta.color = Color.yellow;
  }
 }
}
