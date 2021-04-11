using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Teleporter : MonoBehaviour
{
    [SerializeField]
    private GameObject Sight;

    [SerializeField]
    private GameObject Character;

    private Vector2 mousePos;

    void Update()
    {
        if (Input.GetMouseButton(1) && !EventSystem.current.IsPointerOverGameObject())
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Sight.transform.position = new Vector2(mousePos.x, mousePos.y);
        }
    }

    public void DoTeleportation()
    {
        Character.transform.position = Sight.transform.position;
    }
}
