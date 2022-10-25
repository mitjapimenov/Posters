using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LookAtPosterScript : MonoBehaviour
{
    float distance = 10;
    public TMP_Text pressButtonText;

    private void Start()
    {
        pressButtonText.text = "";
    }

    void OnTriggerEnter(Collider other)
    {
        RaycastHit _hit = new RaycastHit();
        // checks if the raycast 'looks' at the poster

        if (Physics.Raycast(transform.position, transform.forward, out _hit, distance))
        {
            if (other.CompareTag("Poster") && _hit.transform.tag == "Poster")
            {
                // here you give instructions to the player
                // to take the poster in your hand

                other.GetComponent<PosterTask>().poster.SetActive(true);
                
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Poster"))
        {
            // you leave the area
            pressButtonText.text = "";

            other.GetComponent<PosterTask>().poster.SetActive(false);
            Debug.Log("Pelaaja poistui alueelta");
        }
    }
}
