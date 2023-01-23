using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameData gameData;
    //public TextMesh textMesh;

    private void Update()
    {
        //textMesh.text = gameData.coins.ToString();
        gameObject.transform.localScale = new Vector3(1 + gameData.size, 1 + gameData.size, 1 + gameData.size);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            gameData.coins++;
            other.gameObject.SetActive(false);
        }
        else if (other.CompareTag("Tren"))
        {
            gameData.size += 0.1f;
            other.gameObject.SetActive(false);
        }
        else if (other.CompareTag("Veggies"))
        {
            gameData.size -= 0.1f;
            other.gameObject.SetActive(false);
        }
    }
}
