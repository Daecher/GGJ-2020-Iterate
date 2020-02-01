using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IteratorController : MonoBehaviour
{
    public float maxZRotation;
    public float minZRotation;
    public float turnSpeed;
    public float moveSpeed;
    public bool playing = false;
    Transform head;

    float countdownRate = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (playing == true)
        {
            PlayerLook();
            PlayerMove();
        }
    }

    public void StartCycle()
    {
        playing = true;
        transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        StartCoroutine(CycleCountdown(20f));
    }

    public void EndCycle()
    {
        playing = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Destroy(this.gameObject);
        IterationManager.Instance.Ending(
            transform.GetChild(0).rotation,
            transform.GetChild(0).position);
    }

    IEnumerator CycleCountdown(float timeRemaining)
    {
        var tickedTime = timeRemaining;
        yield return new WaitForSecondsRealtime(countdownRate);
        tickedTime -= countdownRate;

        if (tickedTime <= 0)
        {
            Debug.Log("Death");
            IterationManager.Instance.SetCountdownText(0);
            EndCycle();
        }
        else
        {
            IterationManager.Instance.SetCountdownText(tickedTime);
            StartCoroutine(CycleCountdown(tickedTime));
        }

    }

    void PlayerLook()
    {
        var currentBodyRotation = transform.localEulerAngles;
        var currentHeadRotation = transform.GetChild(0).localEulerAngles;
        currentBodyRotation.y += Input.GetAxis("Mouse X") * turnSpeed;
        transform.localEulerAngles = currentBodyRotation;
        float nextTurnFrame = currentHeadRotation.x - (Input.GetAxis("Mouse Y") * turnSpeed);
        if (nextTurnFrame > 180) nextTurnFrame = 360 - nextTurnFrame;
        else if (nextTurnFrame < -180) nextTurnFrame = 360 + nextTurnFrame;
        if (nextTurnFrame < maxZRotation && nextTurnFrame > minZRotation)
        {
            currentHeadRotation.x -= Input.GetAxis("Mouse Y") * turnSpeed;
            transform.GetChild(0).localEulerAngles = currentHeadRotation;
        }
    }

    void PlayerMove()
    {
        transform.localPosition += transform.right * moveSpeed/10f * Input.GetAxis("Horizontal");
        transform.localPosition += transform.forward * moveSpeed/10f * Input.GetAxis("Vertical");
    }
}
