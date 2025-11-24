namespace TelestrationsLibrary;
public static class Globals
{
    // SERVER
    public static readonly string SERVER_BASE_URL = "https://localhost:7228";
    public static readonly int MAX_PLAYERS_PER_GAME = 8;

    // UI
    public static readonly int CANVAS_SIZE_X = 1250;
    public static readonly int CANVAS_SIZE_Y = 775;
    public static readonly float MAX_ZOOM = 4.0f;
    public static readonly float MIN_ZOOM = 0.50f;
    public static readonly int ZOOMED_IN_BORDER_PIXELS = 50;

    public enum DrawingMode { Draw, Fill, Erase, Select }
}
