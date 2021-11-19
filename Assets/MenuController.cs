using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuController : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("Raycast hit!");
        //Location1();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("Clicked!");
        //Location2();
    }
    //public GameObject camera;
    //public GameObject uiCanvas;
    //public GameObject startPoint;
    //public GameObject startPoint2;

    public GameObject[] organs;
    /*public GameObject brain;
    public GameObject higado;
    public GameObject pancreas;
    public GameObject intestino;
    public GameObject estomago;
    public GameObject musculo;
    public GameObject adiposo;*/

    public GameObject pnl_menu;
    public GameObject[] pnl_menuDetail;
    public GameObject pnl_Exit;
    public GameObject moleculas;
    //public GameObject btn_back;

    //Vector3 startPoint2Canvas;

    // Start is called before the first frame update
    void Start()
    {
        //Location1();
    }

    public void Location1()
    {
        //camera.transform.position = startPoint.transform.position;
        //uiCanvas.transform.position = new Vector3(startPoint.transform.position.x, startPoint.transform.position.y, startPoint.transform.position.z + 7);
    }

    public void Location2()
    {
        //camera.transform.position = startPoint2.transform.position;
        //uiCanvas.transform.position = new Vector3(startPoint2.transform.position.x, startPoint2.transform.position.y, startPoint2.transform.position.z + 7);
    }

    public void HideAllOrgans()
    {
        for(int i=0; i<organs.Length; i++)
        {
            organs[i].SetActive(false);
        }
    }

    public void HidePanelDetails()
    {
        for(int i=0; i<pnl_menuDetail.Length; i++)
        {
            pnl_menuDetail[i].SetActive(false);
        }
    }

    public void ShowOrgan(int _organ)
    {
        HideAllOrgans();
        HidePanelDetails();
        pnl_menu.SetActive(false);
        moleculas.SetActive(false);
        
        pnl_menuDetail[_organ].SetActive(true);
        organs[_organ].SetActive(true);
    }

    public void Repeat(int _organ)
    {
        //StopAllSounds
        /*HideAllOrgans();
        HidePanelDetails();
        pnl_menu.SetActive(false);
        moleculas.SetActive(false);
        
        pnl_menuDetail[_organ].SetActive(true);
        organs[_organ].SetActive(true);*/
    }

    /*public void HideAllOrgans()
    {
        brain.SetActive(false);
        higado.SetActive(false);
        pancreas.SetActive(false);
    }

    public void ShowBrain()
    {
        HideAllOrgans();
        pnl_menu.SetActive(false);
        pnl_menuDetail.SetActive(true);
        //btn_back.SetActive(true);
        brain.SetActive(true);
    }

    public void ShowHigado()
    {
        HideAllOrgans();
        pnl_menu.SetActive(false);
        pnl_menuDetail.SetActive(true);
        //btn_back.SetActive(true);
        higado.SetActive(true);
    }

    public void ShowPancreas()
    {
        HideAllOrgans();
        pnl_menu.SetActive(false);
        pnl_menuDetail.SetActive(true);
        //btn_back.SetActive(true);
        pancreas.SetActive(true);
    }

    public void ShowIntestino()
    {
        HideAllOrgans();
        pnl_menu.SetActive(false);
        pnl_menuDetail.SetActive(true);
        //btn_back.SetActive(true);
        intestino.SetActive(true);
    }

    public void ShowEstomago()
    {
        HideAllOrgans();
        pnl_menu.SetActive(false);
        pnl_menuDetail.SetActive(true);
        //btn_back.SetActive(true);
        estomago.SetActive(true);
    }

    public void ShowMusculo()
    {
        HideAllOrgans();
        pnl_menu.SetActive(false);
        pnl_menuDetail.SetActive(true);
        //btn_back.SetActive(true);
        musculo.SetActive(true);
    }

    public void ShowAdiposo()
    {
        HideAllOrgans();
        pnl_menu.SetActive(false);
        pnl_menuDetail.SetActive(true);
        //btn_back.SetActive(true);
        adiposo.SetActive(true);
    }*/

    public void back()
    {
        HideAllOrgans();
        HidePanelDetails();
        pnl_menu.SetActive(true);
        moleculas.SetActive(true);
        //pnl_menuDetail.SetActive(false);
        //btn_back.SetActive(false);
    }

    public void ShowSureExit()
    {
        pnl_Exit.SetActive(true);
    }

    public void HideSureExit()
    {
        pnl_Exit.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
