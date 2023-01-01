using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitButton : MonoBehaviour
{
    public bool isHit;
    public Score score;
    private float delay = 0.5f;
    private float rotationX;

    private void Update()
    {
        rotationX = Mathf.Abs(Player.Instance.transform.rotation.eulerAngles.x);
    }
    public void OnButtonClick()
    {
        if (rotationX <= 10 || (rotationX >= 80 && rotationX <= 100) || (rotationX >= 170 && rotationX <= 190) || (rotationX >= 260 && rotationX <= 280) || rotationX >= 350 && isHit == false)
        {
            StartCoroutine(ResetHit());
            score.IncreaseScore();
            isHit = true;
        }
    }

    IEnumerator ResetHit()
    {
        yield return new WaitForSeconds(delay);
        isHit = false;
    }
}
