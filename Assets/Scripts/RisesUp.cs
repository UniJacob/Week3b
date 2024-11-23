using UnityEngine;

public class RisesUp : MonoBehaviour
{
    public float rotationSpeed;
    private bool isRising = true, isFalling = false;

    void Start()
    {
        transform.rotation = Quaternion.AngleAxis(90, Vector3.right);
    }

    void Update()
    {
        if (isRising)
        {
            RiseUp();
        }
        else if (isFalling)
        {
            FallDown();
        }
    }

    private void RiseUp()
    {
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.x -= rotationSpeed * Time.deltaTime;
        if (currentRotation.x < 0)
        {
            currentRotation.x = 0;
            isRising = false;
        }
        transform.eulerAngles = currentRotation;
    }

    private void FallDown()
    {
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.x += rotationSpeed * 3 * Time.deltaTime;
        if (currentRotation.x > 90)
        {
            Destroy(gameObject);
            return;
        }
        transform.eulerAngles = currentRotation;
    }

    public void startFalling(bool wasHit)
    {
        if (isFalling)
        {
            return;
        }
        if (wasHit)
        {
            InfoTracker.addHit();
        }
        else
        {
            InfoTracker.addMiss();
        }
        isFalling = true;
    }
}
