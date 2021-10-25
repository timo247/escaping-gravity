
using UnityEngine;
using UnityEngine.UI;
public class SpaceGate : MonoBehaviour
{

    private bool isInRange;
    private bool isHyperspacing;
    public LoadSpecificScene script;
    private ShipManeuverController shipManeuverController;
    // Start is called before the first frame update
    public Text interactUI;


    //Une boite de collisison est déèpposée sur la plteforme supérieure à l'échelle. On le trigger quand le joueur monte l'échelle, puis le désactive de sore qu'il puisse marcher dessus une fois qu e le joueur quitte l'échelle
    void Awake()
    {
    interactUI = GameObject.FindGameObjectWithTag("InteractUI").GetComponent<Text>();
    script = this.GetComponent<LoadSpecificScene>();

    }

    // Update is called once per frame
    void Update()
    {
        if(isInRange && Input.GetKeyDown(KeyCode.J))
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
            Debug.Log("player entre dans la porte");
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
