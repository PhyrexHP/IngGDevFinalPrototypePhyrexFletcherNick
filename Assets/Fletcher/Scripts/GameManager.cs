using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject head;
    int headChoiceIndex = 0;

    public GameObject body;
    int bodyChoiceIndex = 0;

    public TMP_Text headBox;
    public TMP_Text bodyBox;

    public List<string> headChoicesNumber;
    public List<Sprite> headChoicesSprite;

    public List<string> bodyChoicesNumber;
    public List<Sprite> bodyChoicesSprite;

    private SpriteRenderer headSR;
    private SpriteRenderer bodySR;
    // Start is called before the first frame update
    void Start()
    {
        headSR = head.GetComponent<SpriteRenderer>();
        bodySR = body.GetComponent<SpriteRenderer>();
        setBody();
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

    public void nextBodyChoice()
    {
        if (bodyChoiceIndex < (bodyChoicesNumber.Count - 1))
        {
            bodyChoiceIndex++;
            setBody();
        }
    }

    public void prevBodyChoice()
    {
        if (bodyChoiceIndex > 0)
        {
            bodyChoiceIndex--;
            setBody();
        }
    }

    void setHead()
    {
        headSR.sprite = headChoicesSprite[headChoiceIndex];
        headBox.text = headChoicesNumber[headChoiceIndex];
    }

    void setBody()
    {
        bodySR.sprite = bodyChoicesSprite[bodyChoiceIndex];
        bodyBox.text = bodyChoicesNumber[bodyChoiceIndex];
    }
}
