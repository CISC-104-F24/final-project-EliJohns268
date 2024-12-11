using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string turtleName = "turtledude";
    public float baseSpeed = 4.0f;
    public Vector3 movementDirection = Vector3.right;
    public float distanceTraveled = 0f;
    public float winningDistance = 50f;
    public int votesReceived = 1;
    public float speedPerVote = 0.05f;
    public KeyCode voteKey;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isVoteKeyPressed = Input.GetKeyDown(voteKey);
        if (isVoteKeyPressed)
        {
            votesReceived = votesReceived + 1;
        }


        float moveStep = (baseSpeed + votesReceived * speedPerVote) * Time.deltaTime;
        transform.position = transform.position + movementDirection * moveStep;
        distanceTraveled = distanceTraveled + moveStep;


    }
}
