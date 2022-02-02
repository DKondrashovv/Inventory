using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class Set : MonoBehaviour, IDropHandler,IPointerEnterHandler,IPointerExitHandler
{
    private event Action OnPlanetClick;
    public void OnDrop(PointerEventData eventData)
    {
        var planet = PlanetTrade.planetTrade;
        if (planet != null && transform.childCount==0)
        { 
            planet.transform.SetParent(transform);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        OnPlanetClick?.Invoke();
        transform.DOScale(Vector3.one*1.2f, 0.3f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(Vector3.one, 0.3f);
    }
}
