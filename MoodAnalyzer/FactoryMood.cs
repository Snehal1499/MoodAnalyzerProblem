using System;
using System.Reflection;
namespace Mood_Analyzer_problem
{
    public class FactoryMood<Gtype>
    {
        //type of is a class it will take anything class
        //and can take metadata 
        Type type = typeof(Gtype);

        public object GetObjectByDefaultConstructor()
        { 
            // MyClass myClsObj = new MyClass()
            //get constructor
            ConstructorInfo[] constructor = type.GetConstructors();
            ConstructorInfo mycon = constructor[0];
            //it will create obj and assign memory in new obj
            //invoke is a method inside this constructor infomation
            var myObj = mycon.Invoke(new object[0]);
            return myObj;
        }
        public object GetObjectByParameterizedConstructor(string msg)
        {
           
            // MyClass myClsObj = new MyClass()
            //get constructor
            ConstructorInfo[] constructor = type.GetConstructors();
            ConstructorInfo mycon = constructor[0];
          
            //invoke is a method inside this constructor infomation
            var myObj = Activator.CreateInstance(mycon.DeclaringType, msg);
            return myObj;
        }
    }
}
