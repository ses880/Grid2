using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMoveScript : MonoBehaviour
{
    TextMeshPro movesText;
    public int moves = 6;
    public bool gameOver;
    public static PlayerMoveScript Instance;
    // Start is called before the first frame update
    void Start()
    {
        moves = 6;
        movesText = GetComponent<TextMeshPro>();
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        movesText.text = moves.ToString();

        /*if (Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d") || Input.GetKeyDown("w"))
        {
            moves -= 1;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            moves -= 1;
        }
        */
        if (moves < 0)
        {
            moves = 0;
        }

        if (moves == 0)
        {
            gameOver = true;
        }

    }
}
