using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlaneteMenuButtons : MonoBehaviour
{

public GameObject PlaneteMenuPanel;
public GameObject MarketMenuPanel;
public GameObject HangOutZoneMenuPanel;
public GameObject MissionMenuPanel;
public GameObject TradeCenterMenuPanel;

public string SceneLevelToDisplay;

    void Start()
     {
         PlaneteMenuPanel.SetActive(true);
         MarketMenuPanel.SetActive(false);
     }



    public void displayGameScene()
    {
        SceneManager.LoadScene(SceneLevelToDisplay);
    } 

         public void ShowMarketPanel()
     {
         PlaneteMenuPanel.SetActive(false);
         MarketMenuPanel.SetActive(true);
     }

        public void HideMarketPanel()
        {
         PlaneteMenuPanel.SetActive(true);
         MarketMenuPanel.SetActive(false); 
        }


         public void ShowHangOutZonePanel()
     {
         PlaneteMenuPanel.SetActive(false);
         HangOutZoneMenuPanel.SetActive(true);
     }

        public void HideHangOutZonePanel()
        {
         PlaneteMenuPanel.SetActive(true);
         HangOutZoneMenuPanel.SetActive(false); 
        }    


         public void ShowMissionMenuPanel()
     {
         Debug.Log("clic mission pris");
         PlaneteMenuPanel.SetActive(false);
         MissionMenuPanel.SetActive(true);
     }

        public void HideMissionMenuPanel()
        {
         PlaneteMenuPanel.SetActive(true);
         MissionMenuPanel.SetActive(false); 
        }


         public void ShowTradeCenterMenuPanel()
     {
         PlaneteMenuPanel.SetActive(false);
         TradeCenterMenuPanel.SetActive(true);
     }

        public void HideTradeCenterMenuPanel()
        {
         PlaneteMenuPanel.SetActive(true);
         TradeCenterMenuPanel.SetActive(false); 
        }       


      public void ShowPlaneteMenuPanel()
     {
         PlaneteMenuPanel.SetActive(true);
         MarketMenuPanel.SetActive(false);
     }

     public void ConfirmClick(){
         Debug.Log("Click enregistré");
     }

    // Update is called once per frame
    void Update()
    {
        

    

    }
}
