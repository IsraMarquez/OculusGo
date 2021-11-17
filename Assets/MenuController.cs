using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuController : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Raycast hit!");
        Location1();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked!");
        Location2();
    }
    public GameObject camera;
    public GameObject uiCanvas;
    public GameObject startPoint;
    public GameObject startPoint2;

    Vector3 startPoint2Canvas;

    // Start is called before the first frame update
    void Start()
    {
        Location1();
    }

    public void Location1()
    {
        camera.transform.position = startPoint.transform.position;
        uiCanvas.transform.position = new Vector3(startPoint.transform.position.x, startPoint.transform.position.y, startPoint.transform.position.z + 7);
    }

    public void Location2()
    {
        camera.transform.position = startPoint2.transform.position;
        uiCanvas.transform.position = new Vector3(startPoint2.transform.position.x, startPoint2.transform.position.y, startPoint2.transform.position.z + 7);
    }
}
