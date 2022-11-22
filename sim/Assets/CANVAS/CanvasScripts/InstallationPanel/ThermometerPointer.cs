﻿using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ThermometerPointer : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [SerializeField] private Material material;
    private GameObject[] thermomParts;
    private Text text;
    private CameraScript cs;
    private string prevText;

    private void Awake()
    {
        cs = GameObject.Find("Main Camera").GetComponent<CameraScript>();
        text = GameObject.FindGameObjectsWithTag("GT")[0].GetComponent<Text>();
        thermomParts = GameObject.FindGameObjectsWithTag("ThermShell");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        prevText = text.text;
        text.text = "Термометр. Используется для измерения температуры проводника.";
        foreach (var part in thermomParts) part.GetComponent<Renderer>().material.color = Color.green;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        text.text = prevText;
        foreach (var part in thermomParts) part.GetComponent<Renderer>().material = material;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        cs.SetNeedPosAndRot(new Vector3(9.2f, 13.9f, -183.7f), Quaternion.Euler(57.998f, 0, 0));
    }

}