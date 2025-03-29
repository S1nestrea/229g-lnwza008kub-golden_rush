using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentGenerator : MonoBehaviour
{
    public GameObject[] segment; // Array ของ Segment
    [SerializeField] int zPos = 50;
    [SerializeField] float spawnInterval = 3f; // ระยะเวลาหลังจากสร้างแต่ละครั้ง
    [SerializeField] int segmentNum;

    private void Start()
    {
        // เริ่มการสร้าง Segment ทุก 3 วินาที
        InvokeRepeating(nameof(SegmentGen), 0f, spawnInterval);
    }

    void SegmentGen()
    {
        segmentNum = Random.Range(0, segment.Length); // เลือก Segment แบบสุ่ม
        Instantiate(segment[segmentNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50; // เลื่อนตำแหน่งถัดไป
    }
}




