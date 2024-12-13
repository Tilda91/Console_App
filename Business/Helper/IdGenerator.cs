using System;

namespace MainApp
{
    public static class IdGenerator
    {
       
        public static Guid GenerateGuidId()
        {
            return Guid.NewGuid();
        }
    }
}