using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public CardData card;

    public TMP_Text cardNameText;
    public TMP_Text cardDescriptionText;

    public Image cardArtworkSprite;
    public TMP_Text cardPointsText;
    public TMP_Text cardCostText;
    public TMP_Text cardVirtuePointsText;
    void Start()
    {
        cardNameText.text = card.cardName;
        cardDescriptionText.text = card.cardDescription;
        cardArtworkSprite.sprite = card.cardArtwork;
        cardPointsText.text = card.cardPoints.ToString();
        cardCostText.text = card.cardCost.ToString();
        cardVirtuePointsText.text= card.cardVirtuePoints.ToString();
    }
}
