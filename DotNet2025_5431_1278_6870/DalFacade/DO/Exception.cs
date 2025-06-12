

namespace DO;
[Serializable]
public class DalIdDoesNotExist : Exception
{
	public DalIdDoesNotExist(String message):base(message)
	{
		
	}
}

[Serializable]
public class DalIdAlreadyExists : Exception
{
	public DalIdAlreadyExists(String message):base(message)
	{

	}

}
[Serializable]
public class DalNotFound : Exception
{
    public DalNotFound(String message) : base(message)
    {

    }

}

