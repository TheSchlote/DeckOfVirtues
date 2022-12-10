using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<CardData> deck = new();
    public GameObject cardTemplate;
    public Transform[] cardSlots;
    public bool[] availableCardSlots;

    public void DrawCard()
    {
        if(deck.Count >= 1)
        {
            CardData randCard = deck[Random.Range(0,deck.Count)];

            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                if (availableCardSlots[i])
                {
                    Instantiate(cardTemplate, new Vector3(cardSlots[i].transform.position.x, cardSlots[i].transform.position.y, cardSlots[i].transform.position.z), Quaternion.identity, cardSlots[i].transform);
                    //randCard.gameObject.SetActive(false);
                    //randCard.transform.position = cardSlots[i].position;
                    availableCardSlots[i] = false;
                    deck.Remove(randCard);
                    Debug.Log(deck.Count);
                    return;
                }
            }
        }
    }
}
