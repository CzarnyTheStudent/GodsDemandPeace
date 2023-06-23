using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 1f;
    public float rotationZoneSize = 50f;
    public float returnSpeed = 5f;
    public Vector3 startPosition;
    public float rotationLimitX = 13f;
    public float rotationLimitY = 26f;
    public float resetDelay = 2f;
    public float resetDelayCenterZone = 1f;
    public float centerZoneSize = 100f;
    
    public Animator cameraAnimator;


    private Quaternion startRotation;
    private Quaternion targetRotation;
    private bool isReturning = false;
    private bool isCenterZoneActive = false;
    private float timeSinceLastInput = 0f;

    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
        
        cameraAnimator = GetComponent<Animator>();
        GetComponent<Animator>().enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (!isReturning)
            {
                isReturning = false;
                StartCoroutine("AnimatorEnabler");
                cameraAnimator.SetBool("MoveCam", true);
               
            }
            else
            {
                isReturning = true;
                StartCoroutine("AnimatorDisabler");
                cameraAnimator.SetBool("MoveCam", false);
                
            }
        }
        RotateCamera();
        ReturnToStart();
    }
    IEnumerator AnimatorEnabler()
    {
        yield return new WaitForSeconds(0.1f);
        GetComponent<Animator>().enabled = true;
    }

    IEnumerator AnimatorDisabler()
    {
        yield return new WaitForSeconds(0.2f);
        GetComponent<Animator>().enabled = false;
    }

    void RotateCamera()
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;

        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        Quaternion currentRotation = transform.rotation;

        float rotationX = currentRotation.eulerAngles.y + mouseX * rotationSpeed;
        float rotationY = currentRotation.eulerAngles.x - mouseY * rotationSpeed;

        // Odwracamy obrót kamery w osi X
        rotationY = -rotationY;

        Quaternion newRotation = Quaternion.Euler(rotationY, rotationX, 0f);

        // Ograniczamy rotację do określonego zakresu
        rotationX = Mathf.Clamp(rotationX, rotationLimitX, 360f - rotationLimitX);
        rotationY = Mathf.Clamp(rotationY, -rotationLimitY, rotationLimitY);

        // Sprawdzamy, czy kursor zbliża się do krawędzi kamery
        bool isMouseNearEdge = (mouseX < rotationZoneSize || mouseX > screenWidth - rotationZoneSize ||
                                mouseY < rotationZoneSize || mouseY > screenHeight - rotationZoneSize);

        // Jeśli kursor zbliża się do krawędzi kamery i nie jesteśmy w strefie środkowej, obracamy kamerę
        if (isMouseNearEdge && !isCenterZoneActive)
        {
            isReturning = false;
            timeSinceLastInput = 0f;

            float targetRotationX = Mathf.Lerp(-rotationLimitX, rotationLimitX, mouseX / screenWidth);
            float targetRotationY = Mathf.Lerp(-rotationLimitY, rotationLimitY, mouseY / screenHeight);

            // Odwracamy obrót kamery w osi X
            targetRotationY = -targetRotationY;

            targetRotation = Quaternion.Euler(targetRotationY, targetRotationX, 0f);

            // Wykorzystujemy Quaternion.Slerp, aby płynnie interpolować między obecną rotacją a nową rotacją
            transform.rotation = Quaternion.Slerp(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
        }
        else if (!isReturning)
        {
            timeSinceLastInput += Time.deltaTime;

            if (timeSinceLastInput > resetDelay)
            {
                isReturning = true;
                targetRotation = startRotation;
            }
        }

        // Sprawdzamy, czy kursor znajduje się w strefie środkowej
        bool isMouseInCenterZone = (mouseX > screenWidth / 2 - centerZoneSize / 2 &&
                                    mouseX < screenWidth / 2 + centerZoneSize / 2 &&
                                    mouseY > screenHeight / 2 - centerZoneSize / 2 &&
                                    mouseY < screenHeight / 2 + centerZoneSize / 2);

        if (isMouseInCenterZone)
        {
            if (!isCenterZoneActive)
            {
                isCenterZoneActive = true;
                timeSinceLastInput = 0f;
            }
            else if (!isReturning)
            {
                timeSinceLastInput += Time.deltaTime;

                if (timeSinceLastInput > resetDelayCenterZone)
                {
                    isReturning = true;
                    targetRotation = startRotation;
                }
            }
        }
        else
        {
            isCenterZoneActive = false;

            // Resetujemy obrót kamery do pozycji startowej
            if (!isReturning)
            {
                timeSinceLastInput += Time.deltaTime;

                if (timeSinceLastInput > resetDelay)
                {
                    isReturning = true;
                    targetRotation = startRotation;
                }
            }
        }
    }

    void ReturnToStart()
    {
        if (isReturning)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, returnSpeed * Time.deltaTime);

            if (Quaternion.Angle(transform.rotation, targetRotation) < 0.01f)
            {
                isReturning = false;
            }
        }
    }

}
