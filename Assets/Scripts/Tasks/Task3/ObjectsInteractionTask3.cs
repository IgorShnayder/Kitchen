using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact

    private Lamp[] _lighter;
    
    private void Start()
    {
        _lighter = FindObjectsOfType<Lamp>();
    }

    private void Update()
    {
        if (!Input.GetKey(KeyCode.Alpha2)) return;
        
        foreach (var lamp in _lighter)
        {
            lamp.Interact();
        }
    }
}