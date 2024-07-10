namespace CremateSkull
{
    public static class Debug
    {
        public static void Log(string message)
        {
#if DEBUG
            Verse.Log.Message($"[{CremateSkullMod.PACKAGE_NAME}] {message}");
#endif
        }
    }
}
