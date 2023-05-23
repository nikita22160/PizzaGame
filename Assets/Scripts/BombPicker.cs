using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BombPicker : MonoBehaviour
{
    private float coins = 3;
    public TMP_Text coinsText;
    private void OnTriggerEnter2D(Collider2D coll)
    {
       if (coll.gameObject.tag == "Bomb")
       {
        coins = coins -1;
        coinsText.text = coins.ToString();
        Destroy(coll.gameObject);
       }
    }

}
