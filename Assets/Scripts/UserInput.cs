using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetMouseClick();
    }

    void GetMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -10));
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit)
            {
                // Deck/Card/EmptySlot...
                if (hit.collider.CompareTag("Deck"))
                {
                    //clicked deck
                    Deck();
                }
                else if (hit.collider.CompareTag("Card"))
                {
                    //clicked card
                    Card();
                }
                else if (hit.collider.CompareTag("Top"))
                {
                    //clicked top
                    Top();
                }
                else if (hit.collider.CompareTag("Bottom"))
                {
                    //clicked bottom
                    Bottom();
                }
            }    
        }
    }

    void Deck()
    {
        // deck click actions
        print("Click Deck");
    }
    void Card()
    {
        // card click actions
        print("Click Card");
    }
    void Top()
    {
        // top click actions
        print("Click Top");
    }
    void Bottom()
    {
        // bottom click actions
        print("Click Bottom");
    }
}
