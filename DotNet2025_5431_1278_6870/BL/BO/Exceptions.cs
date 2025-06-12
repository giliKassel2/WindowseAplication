
namespace BO;

public class Exceptions
{

    [Serializable]
    public class BlDoesNotExistException : Exception
    {
        public BlDoesNotExistException(string? message) : base(message) { }
        public BlDoesNotExistException(string message, Exception innerException)
                    : base(message, innerException) { }
    }
    public class BlOutOfStockExistException : Exception
    {
        public BlOutOfStockExistException(string? message) : base(message) { }
        public BlOutOfStockExistException(string message, Exception innerException)
                    : base(message, innerException) { }
    }


    [Serializable]
    public class BllIdAlreadyExists : Exception
    {
        public BllIdAlreadyExists(String? message) : base(message) { }
        public BllIdAlreadyExists(string message, Exception innerException)
                    : base(message, innerException) { }
    }

    [Serializable]
    public class BlNotFound : Exception
    {
        public BlNotFound(String message) : base(message){ }
        public BlNotFound(string message, Exception innerException)
                    : base(message, innerException) { }
    }
}
