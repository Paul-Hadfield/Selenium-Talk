using System;

namespace Example7.Common
{
    public static class Throw
    {
        public static void IfNull(object param, string paramName)
        {
            if (param == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        public static void IfNullEmptyOrWhiteSpace(string param, string paramName)
        {
            Throw.IfNull(param, paramName);

            if (string.IsNullOrWhiteSpace(param))
            {
                throw new ArgumentException("Parameter must not be empty, or whitespace", paramName);
            }
        }
    }
}