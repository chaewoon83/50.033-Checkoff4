using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float Left_Limit;
    float Right_Limit;
    float Bot_Limit;
    private float viewportHalfWidth;
    private float viewportHalfHeight;
    float Speed;
    Vector2 CamMoveVec;
    Vector3 startPosition;

    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Left_Limit = GameObject.FindGameObjectWithTag("LeftLimit").transform.position.x;
        Right_Limit = GameObject.FindGameObjectWithTag("RightLimit").transform.position.x;
        Bot_Limit = GameObject.FindGameObjectWithTag("BotLimit").transform.position.y;
        Vector3 bottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        viewportHalfWidth = Mathf.Abs(bottomLeft.x - this.transform.position.x);
        viewportHalfHeight = Mathf.Abs(bottomLeft.y - this.transform.position.y);
        Debug.Log("Camera On");
        startPosition = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 NewCamPos = CalCamPos();

        this.transform.position = NewCamPos;
    }

    Vector3 CalCamPos()
    {
        Vector3 NewCamPos = new Vector3 (Player.transform.position.x, Player.transform.position.y, -10.0f);
        if (Left_Limit > transform.position.x - viewportHalfWidth)
        {
            NewCamPos.x = Left_Limit + viewportHalfWidth;
        }
            
        if (Right_Limit < transform.position.x + viewportHalfWidth)
        {
            NewCamPos.x = Right_Limit - viewportHalfWidth;
        }
        if (Bot_Limit > transform.position.y - viewportHalfHeight)
        {
            NewCamPos.y = Bot_Limit + viewportHalfHeight;
        }

        Vector3 CalCamPOSI =  Vector3.Lerp(this.transform.position, NewCamPos, 0.02f);
        CamMoveVec = NewCamPos - new Vector3(this.transform.position.x, this.transform.position.y, -10.0f);
        Speed = CamMoveVec.magnitude * 4.0f;
        CamMoveVec.Normalize();

        NewCamPos = new Vector2(this.transform.position.x, this.transform.position.y) + CamMoveVec * Speed * Time.deltaTime;

        if (Left_Limit > NewCamPos.x - viewportHalfWidth)
        {
            NewCamPos.x = Left_Limit + viewportHalfWidth;
        }

        if (Right_Limit < NewCamPos.x + viewportHalfWidth)
        {
            NewCamPos.x = Right_Limit - viewportHalfWidth;
        }
        if (Bot_Limit > NewCamPos.y - viewportHalfHeight)
        {
            NewCamPos.y = Bot_Limit + viewportHalfHeight;
        }

        return new Vector3( NewCamPos.x ,NewCamPos.y, -10.0f);
    }

    public void GameRestart()
    {
        // reset camera position
        transform.position = startPosition;
    }



}
