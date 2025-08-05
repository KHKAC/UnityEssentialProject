using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // 하루(주기)를 몇 초로 할지
    public float dayDuration = 120f; // 120초면 2분 = 1일
    private float timer = 0f;

    Light light;

    void Update()
    {
        timer += Time.deltaTime;
        float dayFraction = timer / dayDuration;
        float sunAngle = dayFraction * 360f;
        // X축 회전을 적용. Y, Z는 초기값 유지를 권장.
        transform.rotation = Quaternion.Euler(sunAngle, 0f, 0f);

        if (timer == dayDuration / 2)
        {
            light.enabled = false;
        }

        if (timer > dayDuration)
        {
            timer = 0f; // 다음 날로 리셋
            light.enabled = true;
        }
                
    }
}
