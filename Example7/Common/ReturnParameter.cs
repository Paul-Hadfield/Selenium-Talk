namespace Example7.Common
{
    public static class ReturnParameter
    {
        public static T OrThrowIfNull<T>(T param, string paramName) where T: class
        {
            Throw.IfNull(param, paramName);
            return param;
        }
    }
}