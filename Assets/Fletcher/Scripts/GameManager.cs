using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject head;
    int headChoiceIndex = 0;

    public TMP_Text headBox;

    public List<string> headChoicesNumber;
    public List<Sprite> headChoicesSprite;

    private SpriteRenderer headSR;
    // Start is called before the first frame update
    void Start()
    {
        headSR = head.GetComponent<SpriteRenderer>();
        setHead();
    }

    public void nextHeadChoice()
    {
        if(headChoiceIndex < (headChoicesNumber.Count - 1))
        {
            headChoiceIndex++;
            setHead();
        }
    }

    public void prevHeadChoice()
    {
        if(headChoiceIndex > 0)
        {
            headChoiceIndex--;
            setHead();
        }
    }

    void setHead()
    {
        headSR.sprite = headChoicesSprite[headChoiceIndex];
        headBox.text = headChoicesNumber[headChoiceIndex];
    }
}
