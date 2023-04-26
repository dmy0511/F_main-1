using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Warrior : MonoBehaviour
{
    public Vector2 Player;
    public TextMeshProUGUI MyScoreText;
    private int ScoreNum;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.transform.CompareTag("Coin"))
        {
            ScoreNum += 1;
            Debug.Log("코인을 획득했다 난 부자다 야호 !");
            Destroy(other.gameObject);
            MyScoreText.text = "Coin : " + ScoreNum;
        }
    }

    void Update()
    {
        Player = Vector2.zero;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Player.x += 0.05f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Player.x -= 0.05f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Player.y += 0.05f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Player.y -= 0.05f;
        }

        transform.Translate(Player);

    }
}
