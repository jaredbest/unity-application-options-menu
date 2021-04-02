public class PauseMenu : SimpleMenu<PauseMenu>
{
    public void OnQuitPressed()
    {
        Hide();
        Destroy(this.gameObject);
        GameMenu.Hide();
    }
}
