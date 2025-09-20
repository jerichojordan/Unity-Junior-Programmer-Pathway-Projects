using UnityEngine;
namespace PersonalProject
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private PlayerController playerController;
        [SerializeField] private SpawnManager spawnManager;
        [SerializeField] private UIManager uIManager;

        public void StartGame()
        {
            spawnManager.InvokeSpawnEnemy();
            playerController.ResetPlayerPosition();
            playerController.isPlaying = true;
        }
        public void FinishGame()
        {
            PauseGame();
            uIManager.setWinUI(true);
        }

        public void GameOver()
        {
            PauseGame();
            uIManager.setGameOverUI(true);
        }
        private void PauseGame() {
            spawnManager.StopSpawnEnemy();
            playerController.isPlaying = false;
        }
    }

}
