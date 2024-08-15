﻿using System.Text;
using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [TestCase("task1")]
        public void addTaskTest(string taskname)
        {
            //arrange
            UserTask task1 = new UserTask();
            task1.taskname = taskname;

            TodoList todo = new TodoList();
            string expected = "task1";

            //act
            string result = todo.Add(task1);

            //assert
            Assert.IsTrue(expected == result);
            
        }

        [Test]
        public void listTasks()
        {
            //arrange
            TodoList list1 = new TodoList();

            UserTask task1 = new UserTask();
            UserTask task2 = new UserTask();
            UserTask task3 = new UserTask();

            list1.Add(task1);
            list1.Add(task2);
            list1.Add(task3);

            string expected = task1.taskname+" "+task2.taskname+" "+task3.taskname+" ";

            //act
            string result = list1.ListAll();

            //assert
            Assert.IsTrue(expected == result);

            
        }
        
    }
}