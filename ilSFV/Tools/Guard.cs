using System;
using System.Collections;
using System.Collections.Generic;

namespace ilSFV
{
    /// <summary>
    /// Static class for checking argument values.
    /// </summary>
    public static class Guard
    {
        /// <summary>
        /// Guards against null arguments.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        public static void ArgumentNotNull(object value, string parameterName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName, string.Format("Parameter '{0}' cannot be null.", parameterName));
            }
        }

        /// <summary>
        /// Guards against null or empty string arguments.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        public static void ArgumentNotNullOrEmptyString(string value, string parameterName)
        {
            ArgumentNotNull(value, parameterName);

            if (value.Length == 0)
            {
                throw new ArgumentException(string.Format("String parameter '{0}' cannot be empty.", parameterName), parameterName);
            }
        }

        /// <summary>
        /// Guards against null or empty list arguments.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        public static void ArgumentNotNullOrEmpty(ICollection value, string parameterName)
        {
            ArgumentNotNull(value, parameterName);

            if (value.Count == 0)
            {
                throw new ArgumentException(string.Format("Parameter '{0}' cannot be empty.", parameterName), parameterName);
            }
        }

        /// <summary>
        /// Guards against null or empty list arguments.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        public static void ArgumentNotNullOrEmpty<T>(ICollection<T> value, string parameterName)
        {
            ArgumentNotNull(value, parameterName);

            if (value.Count == 0)
            {
                throw new ArgumentException(string.Format("Parameter '{0}' cannot be empty.", parameterName), parameterName);
            }
        }
    }
}