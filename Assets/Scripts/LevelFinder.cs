using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinder : MonoBehaviour
{
    [SerializeField] AudioSource levelUpdate;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LV1"))
        {
            levelUpdate.Play();
            StartCoroutine(waitForLoad(1.5f, 1));
        }
        else if (other.gameObject.CompareTag("LV2"))
        {
            levelUpdate.Play();
            StartCoroutine(waitForLoad(1.5f, 2));
        }
        else if (other.gameObject.CompareTag("LV3"))
        {
            levelUpdate.Play();
            StartCoroutine(waitForLoad(1.5f, 3));
        }
    }
    IEnumerator waitForLoad(float a, int index)          // bekleme coroutine fonksiyonu (a = saniye)
    {
        yield return new WaitForSeconds(a);
        SceneManager.LoadScene(index);
    }
}
