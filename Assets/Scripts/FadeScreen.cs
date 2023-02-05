using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeScreen : MonoBehaviour
{
    public GameObject fade;
    void Start()
    {
        //fade = gameObject.GetComponent<Animation>();
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        // change background after 30 seconds
        yield return new WaitForSeconds(10);
        StartCoroutine(FadeInOut());

        // change background after 30 seconds
        yield return new WaitForSeconds(12);
        StartCoroutine(FadeInOut());
    }

    public IEnumerator FadeInOut() {
        fade.SetActive(true);
        fade.GetComponent<Animator>().SetBool("FadeOut", true);
        yield return new WaitForSeconds(1);
        fade.GetComponent<Animator>().SetBool("FadeOut", false);

        fade.SetActive(true);
        fade.GetComponent<Animator>().SetBool("FadeIn", true);
        yield return new WaitForSeconds(1);
        fade.GetComponent<Animator>().SetBool("FadeIn", false);
        fade.SetActive(false);

    }

}
