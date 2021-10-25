using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSpecificScene : MonoBehaviour
{
    public string sceneName;
    public Animator fadeSystem;
    public bool okToLoadScene;

    private void Awake(){
    fadeSystem = GameObject.FindGameObjectWithTag("FadeSystem").GetComponent<Animator>();             
    }

    private void Update(){
         if(okToLoadScene){
                object p = StartCoroutine(loadNextScene());
                Debug.Log("La coroutine est lancée");
            }
    }


    public IEnumerator loadNextScene()
    {
        fadeSystem.SetTrigger("FadeIn");
        yield return new WaitForSeconds(1f);///moment de pause pour synchroniser le fondu avec la durée du chargement de la scène
        SceneManager.LoadScene(sceneName);

    }

}