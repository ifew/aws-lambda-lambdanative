namespace LambdaNative
{
    public static class EntryPoint
    {
        public static void Main()
        {
            LambdaNative.Run<Handler, HelloModel, respondModel>();
        }
    }
}
