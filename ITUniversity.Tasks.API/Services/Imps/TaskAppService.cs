﻿using ITUniversity.Application.Services;

namespace ITUniversity.Tasks.API.Services.Imps
{
    public class TaskAppService : ApplicationService, ITaskAppService
    {
        public void Test()
        {

        }

        public string GetTest()
        {
            return "aaaaa";
        }

        public void TestString(string str)
        {

        }

        public string GetTestString(string str)
        {
            return "aaaaa";
        }

        public void Class(Test test)
        {

        }

        public Test GetClass(Test test)
        {
            return test;
        }

        public Test1 GetClass2(Test1 test)
        {
            return test;
        }
    }
}