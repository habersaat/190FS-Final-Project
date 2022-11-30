using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScreen : MonoBehaviour
{
    public float duration = 2;
    public Color fadeColor = Color.white;
    private Renderer rend;
    public bool fadeOnStart = true;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        if(fadeOnStart) {
            FadeIn();
        }
    }

    public IEnumerator FadeRoutine(float opIn, float opOut) {
        float timer = 0;
        while(timer <= duration) {
            Color update = fadeColor;
            update.a = Mathf.Lerp(opIn, opOut, timer / duration);
            rend.material.SetColor("_Color", update);
            timer += Time.deltaTime;
            yield return null;
        }
        Color final = fadeColor;
        final.a = opOut;
        rend.material.SetColor("_Color", final);
    }

    public void Fade(float opIn, float opOut) {
        StartCoroutine(FadeRoutine(opIn, opOut));
    }

    public void FadeIn() {
        Fade(1,0);
    }

    public void FadeOut() {
        Fade(0,1);
    }
}
