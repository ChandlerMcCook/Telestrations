namespace TelestrationsLibrary;
public static class Globals
{
    // SERVER
    public const string SERVER_BASE_URL = "https://localhost:7228";
    public const int MAX_PLAYERS_PER_GAME = 8;
    
    // UI
    public const int CANVAS_SIZE_X = 1250;
    public const int CANVAS_SIZE_Y = 775;
    public const float MAX_ZOOM = 8.0f;
    public const float MIN_ZOOM = 0.50f;
    public const int ZOOMED_IN_BORDER_PIXELS = 50;

    public const int MAX_GUESS_LEN = 60;

    public enum DrawingMode { Draw, Fill, Erase, Select }
}
