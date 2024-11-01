using UnityEngine;

public class WingMovement : MonoBehaviour
{
    public float wingAmplitude = 30f;
    public float wingFrequency = 2f;
    public float yAmplitude = 1f;
    public float yFrequency = 1f;
    public float speedZ = 1f;
    public float speedX = 1f;

    GameObject UrightWing;
    GameObject LrightWing;
    GameObject UleftWing;
    GameObject LleftWing;

    private Vector3 randomDirection;

    void Start()
    {
        UrightWing = GameObject.Find("BUTT06");
        LrightWing = GameObject.Find("BUTT07");
        UleftWing = GameObject.Find("BUTT09");
        LleftWing = GameObject.Find("BUTT08");

        randomDirection = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
    }

    void Update()
    {
        float wingRotation = wingAmplitude * Mathf.Sin(Time.time * wingFrequency * 2 * Mathf.PI);
        Quaternion wingQuat = Quaternion.Euler(0, 0, wingRotation);
        Quaternion nwingQuat = Quaternion.Euler(0, 0, -wingRotation);

        UrightWing.transform.localRotation = wingQuat;
        LrightWing.transform.localRotation = wingQuat;
        UleftWing.transform.localRotation = nwingQuat;
        LleftWing.transform.localRotation = nwingQuat;

        float yPosition = yAmplitude * Mathf.Sin(Time.time * yFrequency * 2 * Mathf.PI);
        Vector3 newPosition = transform.position + new Vector3(randomDirection.x * speedX * Time.deltaTime, yPosition, randomDirection.z * speedZ * Time.deltaTime);
        
        transform.position = newPosition;
    }
}
