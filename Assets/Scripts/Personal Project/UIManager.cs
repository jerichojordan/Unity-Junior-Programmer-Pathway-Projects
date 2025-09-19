using UnityEngine;

namespace PersonalProject
{
    public class UIManager : MonoBehaviour
    {

        [SerializeField] private SpawnManager spawnManager;
        [SerializeField] private PlayerController playerController;
        [SerializeField] private GameObject startUI;
        [SerializeField] private GameObject gameOverUI;
        [SerializeField] private GameObject winUI;
        public bool isPlaying;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        public void HandleStartButton()
        {
            setStartUI(false);
            StartGame();
        }
        public void HandleRestartGameOverButton()
        {
            setGameOverUI(false);
            StartGame();
        }
        public void HandleRestartWinButton()
        {
            setWinUI(false);
            StartGame();
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
        public void StartGame()
        {
            isPlaying = true;
            spawnManager.InvokeSpawnEnemy();
            playerController.ResetPlayerPosition();
        }
    }

}
