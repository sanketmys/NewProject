﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKProject
{
           public static class Person
    {
        static void Main()
        {

            {
                Console.WriteLine("Enter no of records");
                int size = Convert.ToInt16(Console.ReadLine());

                for (int i = 0; i < size; i++)
                {
                    Person[] array = new Person[size];

                    if (array[i] == null)
                    {
                        Person[] values = new Person[i];
                        Console.WriteLine("Enter User id:  ");
                        var s = Convert.ToString(Console.ReadLine());
                        // array1[i].UserId = s;
                        array[i].UserID = s.ToString();
                        Console.WriteLine("Enter Name:  ");
                        string n = Console.ReadLine();
                        array[i].Name = n;
                        Console.WriteLine("Enter Age:  ");
                        int A = Convert.ToInt16(Console.ReadLine());
                        array[i].Age = A;
                        Console.WriteLine("Enter rollNo:  ");
                        A = Convert.ToInt16(Console.ReadLine());
                        array[i].Rollno = A;

                        int count = 0;
                        count++;

                    }
                    else
                    {
                        Console.WriteLine("Array is already full");
                        Console.ReadLine();

                    }





                }

            }

        }

        }
        }
