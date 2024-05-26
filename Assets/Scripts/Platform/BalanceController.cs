using UnityEngine;

public class BalanceController : MonoBehaviour ,IBallTriger
{
    [SerializeField] Transform balanceTransform;
    [SerializeField] float maxRotationSpeed = 1f; // dönme hýzý
    [SerializeField] float maxRotationAngle = 60f; // dönüþ açýsý sýnýrý

  

    private float currentRotationAngle = 0f;

    void Update()
    {
        Rotate();
    }


    void Rotate()
    {
        float direction = Input.GetAxisRaw("Horizontal");
        float rotationAmount = direction * maxRotationSpeed * Time.deltaTime;

        // Hedef dönüþ açýsýný hesapla ve sýnýrlandýr
        float targetRotationAngle = currentRotationAngle + rotationAmount;
        targetRotationAngle = Mathf.Clamp(targetRotationAngle, -maxRotationAngle, maxRotationAngle);

        // Yeni dönüþ açýsýný ayarla
        balanceTransform.localRotation = Quaternion.Euler(0f, 0f, -targetRotationAngle);

        // Güncel dönüþ açýsýný sakla
        currentRotationAngle = targetRotationAngle;
    }

}
