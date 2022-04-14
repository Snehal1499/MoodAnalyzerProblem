using System;
using System.Reflection;
namespace Mood_Analyzer_problem
{
    public class FactoryMood<Gtype>
    {
       
        //metadata 
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
        public object GetObjectByParameterizedConstructor(string msg)
        {
            
            //get constructor
            ConstructorInfo[] constructor = type.GetConstructors();
            ConstructorInfo mycon = constructor[0];
            
            //invoke is a method inside this constructor infomation
            var myObj = Activator.CreateInstance(mycon.DeclaringType, msg);
            return myObj;
        }

        public string InvokeMood(string msg)
        {
            var myObj = GetObjectByParameterizedConstructor(msg);
            MethodInfo myMethod = type.GetMethod("CheckMoodTwo");
            object res = myMethod.Invoke(myObj, new object[0]);
            return res.ToString();
        }
    }
}
