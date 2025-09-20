using UnityEngine;

namespace PersonalProject
{
    public class UIManager : MonoBehaviour
    {

        [SerializeField] private GameManager gameManager;
        [SerializeField] private GameObject startUI;
        [SerializeField] private GameObject gameOverUI;
        [SerializeField] private GameObject winUI;
        public bool isPlaying;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        public void HandleStartButton()
        {
            setStartUI(false);
            gameManager.StartGame();
        }
        public void HandleRestartGameOverButton()
        {
            setGameOverUI(false);
            gameManager.StartGame();
        }
        public void HandleRestartWinButton()
        {
            setWinUI(false);
            gameManager.StartGame();
        }
        public void setStartUI(bool active)
        {
            startUI.SetActive(active);
        }
        public void setGameOverUI(bool active)
        {
            gameOverUI.SetActive(active);
        }
        public void setWinUI(bool active)
        {
            winUI.SetActive(active);
        }
    }

}
