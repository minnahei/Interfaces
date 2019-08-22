using System;
namespace Interfaces
{
    public interface IPostcode
    {
        bool IsValid(string postcode);
        string Region(string postcode);
    }
}

