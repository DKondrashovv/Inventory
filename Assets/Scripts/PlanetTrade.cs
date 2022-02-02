using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEditor.EventSystems;
using UnityEngine.EventSystems;

public class PlanetTrade : MonoBehaviour, IBeginDragHandler, IDragHandler,IEndDragHandler
{
    public static PlanetTrade planetTrade;
    [SerializeField] private Camera camera;
    private Vector3 startPosition;
    private Transform startBox;
    private CanvasGroup canvasGroup;
    public int coin;
    private void Awake()
    {
        coin = 1;
        canvasGroup = GetComponent<CanvasGroup>();
    }

    
    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.DOScale(Vector3.one * 1.5f, 0.3f);
        planetTrade = this;
        startPosition = transform.position;
        startBox = transform.parent;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //var pos = camera.ScreenToWorldPoint(Input.mousePosition);
        //pos.z = 0f;
        
        //transform.position = pos;
        transform.position = Input.mousePosition;
    }
    

    public void OnEndDrag(PointerEventData eventData)
    {
        
        transform.DOScale(Vector3.one, 0.3f);
        planetTrade = null;
        canvasGroup.blocksRaycasts = true;
        if (startBox == transform.parent)
        {
            transform.position = startPosition;
        }
        else
        {
            transform.localPosition=Vector3.zero;
        }
    }
}
