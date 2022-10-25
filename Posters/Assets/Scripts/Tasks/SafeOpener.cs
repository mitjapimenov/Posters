using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeOpener : MonoBehaviour
{
    [SerializeField]
    GameObject codePanel, closedSafe, openedSafe;
    public static bool isSafeOpened = false;
    void Start()
    {
        codePanel.SetActive(false);
        closedSafe.SetActive(true);
        openedSafe.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isSafeOpened)
        {
            codePanel.SetActive(false);
            closedSafe.SetActive(false);
            openedSafe.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Safe") && !isSafeOpened)
                {
            codePanel.SetActive(true);
            
        Cursor.lockState = CursorLockMode.Confined;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Safe"))
        {
            codePanel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
