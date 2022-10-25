using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CodePanel : MonoBehaviour
{
    [SerializeField]
    TMP_Text codeText;
    string codeTextValue = "";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if(codeTextValue == "2856")
        {
            SafeOpener.isSafeOpened = true;
        }
        if (codeTextValue.Length >= 4)
            codeTextValue = "";
    }
    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}
