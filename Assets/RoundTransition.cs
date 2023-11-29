using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class RoundTransition : MonoBehaviour
{
    public CanvasGroup fadeCanvas;
    public TextMeshProUGUI gameTitle;
    public float transitionDuration = 1.5f;
    public float zoomOutDuration = 0.75f;
    public float zoomInDuration = 0.75f;

    private Vector3 originalTitleScale;

    void Start()
    {
        originalTitleScale = gameTitle.transform.localScale;
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.P))
        {
            StartTransition();
        }
    }

    public void StartTransition()
    {
        StartCoroutine(TransitionSequence());
    }

    IEnumerator TransitionSequence()
    {
        yield return StartCoroutine(FadeCanvas(true));
        yield return StartCoroutine(ZoomTitle(true));


        yield return StartCoroutine(ZoomTitle(false));
        yield return StartCoroutine(FadeCanvas(false));
    }

    IEnumerator FadeCanvas(bool fadeIn)
    {
        float startAlpha = fadeIn ? 0 : 1;
        float targetAlpha = fadeIn ? 1 : 0;
        float elapsedTime = 0;

        while (elapsedTime < transitionDuration)
        {
            fadeCanvas.alpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / transitionDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        fadeCanvas.alpha = targetAlpha;
    }

    IEnumerator ZoomTitle(bool zoomOut)
    {
        Vector3 startScale = zoomOut ? originalTitleScale : originalTitleScale * 3f;
        Vector3 targetScale = zoomOut ? originalTitleScale * 3f : originalTitleScale;
        float duration = zoomOut ? zoomOutDuration : zoomInDuration;
        float elapsedTime = 0;

        while (elapsedTime < duration)
        {
            gameTitle.transform.localScale = Vector3.Slerp(startScale, targetScale, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        gameTitle.transform.localScale = targetScale;
    }
}
