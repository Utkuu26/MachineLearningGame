using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinSystem : MonoBehaviour
{
    public TextMeshProUGUI level1Coin;
    public TextMeshProUGUI level2Coin;
    public TextMeshProUGUI level3Coin;
    public TextMeshProUGUI level4Coin;
    public TextMeshProUGUI level5Coin;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        level1Coin.text = PlayerPrefs.GetInt("Coin").ToString();
        level2Coin.text = PlayerPrefs.GetInt("Coin").ToString();
        level3Coin.text = PlayerPrefs.GetInt("Coin").ToString();
        level4Coin.text = PlayerPrefs.GetInt("Coin").ToString();
        level5Coin.text = PlayerPrefs.GetInt("Coin").ToString();
    }
}
