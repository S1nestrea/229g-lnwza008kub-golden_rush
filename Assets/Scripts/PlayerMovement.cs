using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 2;
    public float horizontalSpeed = 5;
    public float rightlimit = 5.5f;
    public float leftlimit = -5.5f; // ต้องเป็นค่าติดลบเพื่อจำกัดฝั่งซ้าย

    private void Update()
    {
        // เคลื่อนที่ไปข้างหน้าเสมอ
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);

        // เคลื่อนไปทางซ้าย (เมื่อกด A หรือ ลูกศรซ้าย)
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            if (this.gameObject.transform.position.x > leftlimit) // จำกัดขอบซ้าย
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed, Space.World);
            }
        }

        // เคลื่อนไปทางขวา (เมื่อกด D หรือ ลูกศรขวา)
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            if (this.gameObject.transform.position.x < rightlimit) // จำกัดขอบขวา
            {
                transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed, Space.World);
            }
        }
    }
}


