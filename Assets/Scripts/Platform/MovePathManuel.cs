using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class MovePathManuel : MonoBehaviour
{

    [SerializeField] SpriteShapeController spriteShapeController;
    [SerializeField] float moveSpeed = 5f;

    private int currentIndex = 0;
    private bool movingForward = true;

    void Start()
    {
        // Baþlangýçta nesneyi ilk noktaya yerleþtir
        transform.position = spriteShapeController.spline.GetPosition(currentIndex) + spriteShapeController.transform.position;
    }

    void Update()
    {
        MoveAlongSpline();
    }

    void MoveAlongSpline()
    {
        float y = Input.GetAxisRaw("Vertical");

        if (y < 0)
        {
            if (movingForward)
            {
                currentIndex--;
                movingForward = false;
            }
        }
        else if (y > 0)
        {
            if (!movingForward)
            {
                currentIndex++;
                movingForward = true;
            }
        }
        else
        {
            return;
        }

        if (currentIndex >= spriteShapeController.spline.GetPointCount())
        {
            currentIndex = spriteShapeController.spline.GetPointCount() - 1;
        }
        else if (currentIndex < 0)
        {
            currentIndex = 0;
        }

        // Hedef noktaya doðru hareket et
        Vector3 targetPosition = spriteShapeController.spline.GetPosition(currentIndex) + spriteShapeController.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // Kontrol, geçerli indeksin sýnýr deðerlerini aþmadýðýndan emin olmalýdýr
        if (currentIndex >= spriteShapeController.spline.GetPointCount())
        {
            currentIndex = spriteShapeController.spline.GetPointCount() - 1;
        }
        else if (currentIndex < 0)
        {
            currentIndex = 0;
        }

        // Hedef noktaya ulaþýldýðýnda, hareket yönünü deðiþtir
        if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
        {
            if (movingForward)
            {
                currentIndex++;
            }
            else
            {
                currentIndex--;
            }
        }
    }

}
