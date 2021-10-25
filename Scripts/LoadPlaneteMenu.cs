using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadPlanetMenu : MonoBehaviour
{
    public string sceneName;
    public Animator fadeSystem;
    public Text interactUI;
    public LoadSpecificScene script;

    private bool isInRange;

    private void Awake()
    {
    interactUI = GameObject.FindGameObjectWithTag("InteractUI").GetComponent<Text>();
    script = this.GetComponent<LoadSpecificScene>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(isInRange && Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("on passe là");
            //HyperEspace
            script.okToLoadScene = true;
            return;//il faut arrêter le frae sinon il passe au suiant et ça ne marche pas

        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isInRange= true;
            interactUI.enabled = true ;
            return;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
    if(collision.CompareTag("Player"))
            {
                isInRange= false;
                interactUI.enabled = false;
            }
    }

    

    
}
