using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureSafeOpener : MonoBehaviour
{
    [SerializeField]
    GameObject closedSafe, openedSafe;
    public static bool isSafeOpened = false;
    void Start()
    {
        closedSafe.SetActive(true);
        openedSafe.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isSafeOpened)
        {
            closedSafe.SetActive(false);
            openedSafe.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("PuzzleSafe") && !isSafeOpened)
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PuzzleSafe"))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
