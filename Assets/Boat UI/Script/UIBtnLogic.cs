using UnityEngine;

public class UIBtnLogic : MonoBehaviour
{
    public GameObject ArrowDwn;
    public GameObject ArrowUp;
    public GameObject MainUI;
    public GameObject StageUI;

    public void clickArrowDwnBtn() {
        ArrowDwn.SetActive(false);
        ArrowUp.SetActive(true);
        MainUI.SetActive(true);

    }

    public void clickArrowUpBtn() {
        ArrowDwn.SetActive(true);
        ArrowUp.SetActive(false);
        MainUI.SetActive(false);
        StageUI.SetActive(false);
    }

    public void clickStageBtn() {
        StageUI.SetActive(true);
    }

    public void clickXBtn() {
        StageUI.SetActive(false);
    }
}
