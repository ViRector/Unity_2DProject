using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    [SerializeField] private float parallaxMultiplier;

    private Transform cameraTransform;
    private Vector3 PreviousCameraPosition;
    private float SpriteWidth, StartPosition;
    void Start()
    {
        cameraTransform = Camera.main.transform;
        PreviousCameraPosition = cameraTransform.position;
        SpriteWidth = GetComponent<SpriteRenderer>().bounds.size.x;
        StartPosition = transform.position.x;
    }


    void Update()
    {
        float deltaX = (cameraTransform.position.x - PreviousCameraPosition.x) * parallaxMultiplier;
        float MoveAmount = cameraTransform.position.x * (1 - parallaxMultiplier);
        transform.Translate(new Vector3(deltaX, 0, 0));
        PreviousCameraPosition = cameraTransform.position;

        if(MoveAmount > StartPosition + SpriteWidth)
        {
            transform.Translate(new Vector3(SpriteWidth, 0, 0));
            StartPosition += SpriteWidth;
        }
        else if (MoveAmount < StartPosition - SpriteWidth)
        {
            transform.Translate(new Vector3(-SpriteWidth, 0, 0));
            StartPosition -= SpriteWidth; 
        }

    }
}
