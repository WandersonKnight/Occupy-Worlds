using UnityEngine;
using UnityEngine.UI;

public class BuildMenuBlock : MonoBehaviour
{

    #region Initialization / Declaration

    [SerializeField] private Button buildMenuButton1;
    [SerializeField] private Button buildMenuButton2;
    [SerializeField] private Button buildMenuButton3;
    [SerializeField] private Button buildMenuButton4;
    [SerializeField] private Button buildMenuButton5;
    [SerializeField] private Button buildMenuButton6;
    [SerializeField] private Button buildMenuButton7;
    [SerializeField] private Button buildMenuButton8;
    [SerializeField] private Button buildMenuButton9;
    [SerializeField] private Button buildMenuButton10;
    [SerializeField] private Button buildMenuButton11;
    [SerializeField] private Button buildMenuButton12;

    [SerializeField] private Sprite max_buy;

    private SpriteState spriteState;

    #endregion

    void Update()
    {
        if (GlobalMoney.moneyCount < ComprarMultiple.tempBuildCosts[0])
        {
            buildMenuButton1.interactable = false;
        }
        else
        {
            buildMenuButton1.interactable = true;
        }

        if (GlobalMoney.moneyCount < ComprarMultiple.tempBuildCosts[1])
        {
            buildMenuButton2.interactable = false;
        }
        else
        {
            buildMenuButton2.interactable = true;
        }

        if (GlobalMoney.moneyCount < ComprarMultiple.tempBuildCosts[2])
        {
            buildMenuButton3.interactable = false;
        }
        else
        {
            buildMenuButton3.interactable = true;
        }

        if (GlobalMoney.moneyCount < ComprarMultiple.tempBuildCosts[3])
        {
            buildMenuButton4.interactable = false;
        }
        else
        {
            buildMenuButton4.interactable = true;
        }

        if (GlobalMoney.moneyCount < ComprarMultiple.tempBuildCosts[4])
        {
            buildMenuButton5.interactable = false;
        }
        else
        {
            buildMenuButton5.interactable = true;
        }

        if (GlobalMoney.moneyCount < ComprarMultiple.tempBuildCosts[5])
        {
            buildMenuButton6.interactable = false;
        }
        else
        {
            buildMenuButton6.interactable = true;
        }

        if (GlobalMoney.moneyCount < ComprarMultiple.tempBuildCosts[6])
        {
            buildMenuButton7.interactable = false;
        }
        else
        {
            buildMenuButton7.interactable = true;
        }

        if (GlobalMoney.moneyCount < ComprarMultiple.tempBuildCosts[7])
        {
            buildMenuButton8.interactable = false;
        }
        else
        {
            buildMenuButton8.interactable = true;
        }

        if (GlobalMoney.moneyCount < ComprarMultiple.tempAsteroidCosts[0])
        {
            buildMenuButton9.interactable = false;
        }
        else
        {
            buildMenuButton9.interactable = true;
        }

        if (GlobalMoney.moneyCount < ComprarMultiple.tempAsteroidCosts[1])
        {
            buildMenuButton10.interactable = false;
        }
        else
        {
            buildMenuButton10.interactable = true;
        }

        if (GlobalMoney.moneyCount < ComprarMultiple.tempAsteroidCosts[2])
        {
            buildMenuButton11.interactable = false;
        }
        else
        {
            buildMenuButton11.interactable = true;
        }

        if (GlobalMoney.moneyCount < BuildMenu.buildCosts[8] || BuildMenu.gameFinishedCheck == true)
        {
            buildMenuButton12.interactable = false;

            if (BuildMenu.gameFinishedCheck == true)
            {
                spriteState = new SpriteState();
                spriteState.disabledSprite = max_buy;
                buildMenuButton12.spriteState = spriteState;
            }
        }
        else
        {
            buildMenuButton12.interactable = true;
        }
    }

}
