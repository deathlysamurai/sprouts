using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotManager : MonoBehaviour
{
    [SerializeField] InputController inputController;
    [SerializeField] GameObject blueDot;
    [SerializeField] Transform dots;

    private GameObject clickedDot;
    private Vector2 mousePos;

    private void OnEnable()
    {
        inputController.ClickEvent += PlaceDot;
    }

    private void OnDisable()
    {
        inputController.ClickEvent -= PlaceDot;
    }

    private void PlaceDot(Vector2 pos)
    {
        if (IsClickingDot(pos))
        {
            Instantiate(blueDot, clickedDot.transform.position, new Quaternion(), dots);
            Destroy(clickedDot);
        }
    }

    private bool IsClickingDot(Vector2 pos)
    {
        mousePos = Camera.main.ScreenToWorldPoint(pos);
        RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

        if (hit.collider != null)
        {
            Debug.Log(hit.collider);
            clickedDot = hit.collider.gameObject;
            return true;
        } else
        {
            return false;
        }
    }
}
