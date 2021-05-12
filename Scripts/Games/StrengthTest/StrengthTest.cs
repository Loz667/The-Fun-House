using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrengthTest : MonoBehaviour
{
    public Animator hammerAnim;
    public GameObject mainPlayer;
    public GameObject strengthPlayer;
    public GameObject powerIndicator;
    public GameObject theBell;
    public Image powerBarMask;
    public Rigidbody striker;

    BellCollision bellCol;

    public float barChangeSpeed = 1;
    public float hitForceMultiplier;
    float maxPowerBarValue = 1;
    float currentPowerBarValue;

    bool powerIsIncreasing;
    bool powerBarON;

    public GameObject StrikerCamera;
    [SerializeField] private GameObject PlayerCamera;

    public void GameStart()
    {
        bellCol = theBell.GetComponent<BellCollision>();
        currentPowerBarValue = 0;
        powerIsIncreasing = true;
        powerBarON = true;
        StartCoroutine(UpdatePowerBar());
    }

    IEnumerator UpdatePowerBar()
    {
        powerIndicator.SetActive(true);

        while (powerBarON)
        {
            if (!powerIsIncreasing)
            {
                currentPowerBarValue -= barChangeSpeed;
                if (currentPowerBarValue <= 0)
                {
                    powerIsIncreasing = true;
                }
            }
            else if (powerIsIncreasing)
            {
                currentPowerBarValue += barChangeSpeed;
                if (currentPowerBarValue >= maxPowerBarValue)
                {
                    powerIsIncreasing = false;
                }
            }
            
            float fill = currentPowerBarValue / maxPowerBarValue;
            powerBarMask.fillAmount = fill;
            yield return new WaitForSeconds(0.02f);

            if (Input.GetButtonDown("Fire1"))
            {
                powerBarON = false;
                hammerAnim.SetTrigger("Swing");
                StartCoroutine(MoveStriker());
                StrikerCamera.SetActive(!strengthPlayer.activeInHierarchy);

            }
        }
        yield return null;
    }

    IEnumerator MoveStriker()
    {
        //Debug.Log("StrikerMoving");
        yield return new WaitForSeconds(1.5f);
        float _hitForce = currentPowerBarValue * hitForceMultiplier;
        Vector2 _hitVector = new Vector2(0, _hitForce);
        striker.AddForce(_hitVector, ForceMode.Impulse);
        powerIndicator.SetActive(false);
        yield return new WaitForSeconds(2f);
        if (bellCol.beenHit == false)
        {
            StrikerCamera.SetActive(!strengthPlayer.activeInHierarchy);
            strengthPlayer.SetActive(!strengthPlayer.activeInHierarchy);
            mainPlayer.SetActive(!strengthPlayer.activeInHierarchy);
        }
    }
}