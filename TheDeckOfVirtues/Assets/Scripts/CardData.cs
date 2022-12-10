using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "CardData")]
public class CardData : ScriptableObject
{
    public string cardName;
    public string cardDescription;

    public Sprite cardArtwork;
    public int cardPoints;
    public int cardCost;
    public int cardVirtuePoints;

}