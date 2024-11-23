using System.Threading;
using UnityEngine;

public class Timed : MonoBehaviour
{
    [SerializeField] float lifeTime = 2;
    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > lifeTime)
        {
            try
            {
                GetComponent<RisesUp>().startFalling(false);
            }
            catch (System.Exception)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
