using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class textblink : MonoBehaviour
{
    public float blinkInterval = 1f; // Time interval for blinking (in seconds)
    public Animator caseAnimator, camAnimator;
    private TextMeshProUGUI textComponent;
    

    void Start()
    {
        textComponent = GetComponentInChildren<TextMeshProUGUI>();

        // Start the blinking coroutine
        StartCoroutine(BlinkText());
    }

    public void OnTextClicked()
    {
        caseAnimator.SetBool("EnteredMenu", true);
        camAnimator.SetTrigger("Zoom");
        Debug.Log("clicked");
    }

    IEnumerator BlinkText()
    {

        while (true)
        {
            // Toggle the visibility of the text
            textComponent.enabled = !textComponent.enabled;

            // Wait for the specified interval
            yield return new WaitForSeconds(blinkInterval);

           
        }
    }
}
