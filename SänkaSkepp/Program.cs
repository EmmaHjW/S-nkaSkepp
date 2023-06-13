namespace SänkaSkepp
{
    public class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            GameObserver gameObserver = new GameObserver();

            gameManager.AttachObserver(gameObserver);

            gameManager.PlayGame();
        }
    }
}