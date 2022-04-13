using System;
using System.Reflection;
namespace Mood_Analyzer_problem
{
    public class FactoryMood<Gtype>
    {
        //type of is a class it will take anything class
        
        Type type = typeof(Gtype);

        public object GetObjectByDefaultConstructor()
        {
           
            //get constructor
            ConstructorInfo[] constructor = type.GetConstructors();
            ConstructorInfo mycon = constructor[0];
            //invoke is a method inside this constructor infomation
            var myObj = mycon.Invoke(new object[0]);
            return myObj;
        }
    }
}
