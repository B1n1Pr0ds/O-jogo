using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class um : MonoBehaviour
{
    [SerializeField]private float valor = 0;

    [SerializeField] private TextMeshProUGUI cronTxt;
    [SerializeField] private GameObject go;
    
    
    // Start is called before the first frame update
    void Start()
    {
        cronTxt = go.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        valor += Time.deltaTime;
        Associate();
    }


    private void Associate()
    {
        cronTxt.text = valor.ToString();
    }
}
