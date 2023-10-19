﻿namespace muchik.market.infrastructure.crosscutting.Exceptions
{
    internal class BusinessException: Exception
    {
        public BusinessException() { }

        public BusinessException(string message) : base(message) { }

        public BusinessException(string message, Exception innerException) : base(message, innerException) { }
    }
}
