using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleComponent : MonoBehaviour
{
    public GameEvent gameEvent;

    public GameObject component;

    public void Raise()
    {
        gameEvent.Raise();
    }

    public void OnToggle()
    {
        component.SetActive(!component.activeInHierarchy);
    }
}
