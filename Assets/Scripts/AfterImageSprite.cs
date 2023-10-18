using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterImageSprite : MonoBehaviour
{
    public float ghostDelay;
    private float ghostDelaySeconds;
    public GameObject AfterImage;
    public BoolVariable IsDash;
    public BoolVariable FaceRight;
    // Start is called before the first frame update
    void Start()
    {
        ghostDelaySeconds = ghostDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsDash.Value == true)
        {
            if (ghostDelaySeconds > 0.0f)
            {
                ghostDelaySeconds -= Time.deltaTime;
            }
            else
            {
                GameObject CurrentAfterImage = Instantiate(AfterImage, transform.parent.position, transform.parent.rotation);
                Sprite CurSprite = GetComponent<SpriteRenderer>().sprite;
                if (FaceRight.Value == false)
                {
                    CurrentAfterImage.GetComponent<SpriteRenderer>().flipX = true;
                    CurrentAfterImage.GetComponent<SpriteRenderer>().sprite = CurSprite;
                }
                ghostDelaySeconds = ghostDelay;
                Destroy(CurrentAfterImage, 1.0f);
            }
        }
    }
}
