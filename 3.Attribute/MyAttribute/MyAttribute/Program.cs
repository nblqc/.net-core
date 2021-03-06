﻿using MyAttribute.AttrExtend;
using MyAttribute.CustomEnum;
using System;

namespace MyAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Student student = new Student() 
            {
                Id= 1,
                Name = "lqc",
                state = UserState.Forzen,
                salary = 800000
            };

            //Validate.Validating(student);
            student.Validating();

            Console.WriteLine(EnumExt.GetDescriptionThirdPart<UserState>(student.state));
            Console.WriteLine(student.state.GetDescription());
        }
    }
}
