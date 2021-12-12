/*
 * Name: Craig Franceschetti
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2021-11-28
 * Updated: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franceschetti.Craig.RRCAGApp
{
    /// <summary>
    /// Represents a NoRowsException.
    /// </summary>
    class NoRowsException : Exception
    {
        /// <summary>
        /// Initializes an instance of NoRowsException.
        /// </summary>
        public NoRowsException()
        { 
        }

        /// <summary>
        /// Initializes an instance of NoRowsException with an error message.
        /// </summary>
        /// <param name="message">Error Message</param>
        public NoRowsException(string message)
            :base (message)
        {
        }

        /// <summary>
        /// Initializes an instance of NoRowsException with an error message and a reference to the inner exception that caused this exception.
        /// </summary>
        /// <param name="message">Error Message.</param>
        /// <param name="inner">Inner Exception that causes the NoRowsException.</param>
        public NoRowsException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
