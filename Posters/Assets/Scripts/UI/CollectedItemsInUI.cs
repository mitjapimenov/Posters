using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectedItemsInUI : MonoBehaviour
{
    [SerializeField]
    private Image appleImg, corgiImg, keyImg;
    [SerializeField]
    private GameObject apple, corgi, key;
    [SerializeField]
    private TMP_Text NPCText;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.name == "Apple")
        {
            appleImg.gameObject.SetActive(true);
            Destroy(apple);
        }
        if (collision.transform.name == "Corgi")
        {
            corgiImg.gameObject.SetActive(true);
            Destroy(corgi);
        }
        if (collision.transform.name == "Key")
        {
            keyImg.gameObject.SetActive(true);
            Destroy(key);
        }

        if (collision.transform.name == "Grandma" && appleImg.IsActive())
        {
            Debug.Log("Omenat poissa ja mummo kiitollinen");
            NPCText.text = "Oh but well thank you. I am allergic, but I will give these to my pigs.";
            Destroy(appleImg);
        }
        if (collision.transform.name == "LockSafe" && keyImg.IsActive())
        {
            Debug.Log("Lukko auki ja avaimet poissa");
            NPCText.text = "Safe Opened";
            Destroy(keyImg);
        }
    }
}
